﻿using BreadTh.StronglyApied.Attributes;

namespace BreadTh.Bunder
{
    [StronglyApiedRoot(DataModel.Json)]
    public class Envelope<T>
    {
        [StronglyApiedString()]
        public string traceId;

        [StronglyApiedObject()]
        public T letter;
       
        [StronglyApiedObject()]
        public MessageHistory history;
    }
}
