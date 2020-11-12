using System;
using System.Windows.Forms;

namespace ComputingProject2
{
    class PartialQueue // inspired by priority queue for the dequeue procedure 
    {
        private Flashcard[] _queue;
        private int _size;
        private int _pointer;
        private int _back;
        private RichTextBox _text1, _text2;

        public PartialQueue(Set set, RichTextBox textBox1, RichTextBox textBox2)
        {
            _size = 64;
            _queue = new Flashcard[_size];
            _pointer = 0;
            _back = 0;
            _text1 = textBox1;
            _text2 = textBox2;

            foreach (var card in set.Flashcards)
            {
                _queue[_back] = card;
                _back++;
            }
        }

        public int Forwards()
        {
            if (_back != 0)
            {
                _pointer = (_pointer + 1) % _back; // if back equalled zero there would be a divide by zero error
                return _pointer + 1;
            }

            return 1;

        }

        public int Backwards()
        {
            _pointer = _pointer == 0 ? _back - 1 : _pointer - 1; // when pointer = 0 it is at the start of the queue. Therefore it will wrap around to the back of the queue.

            return _pointer + 1;
        }

        public Flashcard Load() // displays flashcard
        {
            _text1.Text = _queue[_pointer].text1;
            _text2.Text = _queue[_pointer].text2;
            return _queue[_pointer];
        }

        public void Enqueue(Flashcard flashcard) // error handling occurs earlier on in add procedure
        {
            _queue[_back] = flashcard;
            _back++;
        }

        public void Dequeue() // error handlind occurs earlier in remove procedure
        {
            for (int i = _pointer; i < _back-1; i++)
            {
                _queue[_pointer] = _queue[_pointer + 1];
            }
            _back--;
        }

        public Flashcard GetFlashcard
        {
            get
            {
                return _queue[_pointer];
            }
        }

        public Flashcard[] GetQueue
        {
            get
            {
                return _queue;
            }
        }
    }
}