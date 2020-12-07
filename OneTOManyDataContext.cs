using System;

namespace one_many
{
    internal class OneTOManyDataContext
    {
        public OneTOManyDataContext()
        {
        }

        public object Orders { get; internal set; }

        internal void savechanges()
        {
            throw new NotImplementedException();
        }
    }
}