using System;

namespace Shop
{
    public class IPhone
    {
        private IPhoneModels _model;
        private int _cost;
        private int _memory;
        private ConsoleColor _color;

        public IPhone(IPhoneModels model, int cost, int memory, ConsoleColor color)
        {
            _model = model;
            _cost = cost;
            _memory = memory;
            _color = color;
        }
    }
}
