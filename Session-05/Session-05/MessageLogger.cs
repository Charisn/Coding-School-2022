using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class MessageLogger
    {
        public MessageLogger[] Messages { get; set; }

        int _count;
        private Messages[] _messages;

        public MessageLogger()
        {
            _messages = new Messages[100];
            _count = 0;
        }

        public MessageLogger[] ReadAll()
        {
            return Messages;
        }


        public void Write(Messages messageTemp)
        {
            if (_count == _messages.Length)
                Array.Resize(ref _messages, _messages.Length * 2);

            _messages[_count++] = messageTemp;
        }
        public void Write(string messageTemp)
        {
            Console.WriteLine(messageTemp);
        }
        public void Clear()
        {
            Array.Clear(_messages, 0, _count);
            _count=0;
        }
    }
}
