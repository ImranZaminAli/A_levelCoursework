using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Google.Apis.Download;
using Google.Apis.Requests;
using System.IO;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using File = Google.Apis.Drive.v3.Data.File;
using Files = System.IO.File;

namespace ComputingProject2
{
    class GDrive
    {
        string[] scopes = { DriveService.Scope.Drive, DriveService.Scope.DriveAppdata, DriveService.Scope.DriveFile, DriveService.Scope.DriveMetadata };
        string applicationName = "Drive API .NET Quickstart";
        DriveService service;

        public GDrive()
        {
            UserCredential credential;

            using (var stream =
                new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token1.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
            }

            // Create Drive API service.
            service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = applicationName,
            });
        }


        public List<Google.Apis.Drive.v3.Data.File> GetDriveFiles()
        {
            // Define parameters of request.
            FilesResource.ListRequest listRequest = service.Files.List();
            listRequest.PageSize = 10;
            listRequest.Fields = "nextPageToken, files(id, name)";

            // List files.
            List<Google.Apis.Drive.v3.Data.File> files = (List<Google.Apis.Drive.v3.Data.File>)listRequest.Execute().Files;

            return files;
        }

        public void DownloadDatabase()
        {
            // Define parameters of request.
            FilesResource.ListRequest listRequest = service.Files.List();
            listRequest.PageSize = 10;
            listRequest.Fields = "nextPageToken, files(id, name)";

            // List files.

            IList<Google.Apis.Drive.v3.Data.File> files = (IList<Google.Apis.Drive.v3.Data.File>) GetDriveFiles();

            if (files != null && files.Count > 0)
            {
                foreach (var file in files)
                {
                    if (file.Name.IndexOf(".db") != -1)
                    {

                        DirectoryInfo directory = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
                        FileInfo[] fileInfo = directory.GetFiles(file.Name);

                        if (fileInfo.Length != 0)
                        {
                            foreach (var delete in fileInfo)
                            {
                                delete.Delete();
                            }
                        }

                        FilesResource.GetRequest request = service.Files.Get(file.Id);
                        MemoryStream stream = new System.IO.MemoryStream();

                        request.Download(stream);

                        request.MediaDownloader.ProgressChanged += (IDownloadProgress progress) =>
                        {
                            if (progress.Status == DownloadStatus.Completed)
                            {
                                new MessageForm("successful").Show();
                            }
                            else if (progress.Status == DownloadStatus.Failed)
                            {
                                MessageForm errorForm = new MessageForm("Failed to download database");
                                errorForm.Show();
                            }

                        };


                        using (System.IO.FileStream download = new FileStream(AppDomain.CurrentDomain.BaseDirectory + @"\database.db", FileMode.Create, FileAccess.Write))
                        {
                            download.Write(stream.GetBuffer(), 0, stream.GetBuffer().Length);
                        }

                        stream.Flush();
                        stream.Close();
                    }


                }
            }
        }


        public void UploadDatabase()
        {

            DirectoryInfo directoryInfo = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);

            FileInfo[] fileInfos = directoryInfo.GetFiles();

            string path = "";

            foreach (var info in fileInfos)
            {
                if(info.Name.IndexOf(".db") != -1)
                {
                    path = info.FullName;
                }
            }

            var fileMetadata = new File()
            {
                Name = "database.db"
            };
            

            FilesResource.CreateMediaUpload request;
            using (var stream = new System.IO.FileStream(path, System.IO.FileMode.Open))
            {
                
                request = service.Files.Create(fileMetadata, stream, "database/db");
                request.Fields = "id";
                DeleteDriveDatabase();
                using (service)
                {
                    request.Upload();
                }
            }
            var file = request.ResponseBody;
            Console.WriteLine("File ID: " + file.Id);

        }

        public void DeleteDriveDatabase()
        {
            List<Google.Apis.Drive.v3.Data.File> files = GetDriveFiles();

            foreach (var file in files)
            {
                if(file.Name.IndexOf(".db") != -1)
                {
                    service.Files.Delete(file.Id).Execute();
                }
            }
        }

    }
}
