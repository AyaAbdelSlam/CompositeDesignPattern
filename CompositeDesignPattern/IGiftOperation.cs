using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeDesignPattern
{
    public interface IGiftOperation
    {
        void Add(GiftBase gift);
        void Remove(GiftBase gift);
    }
}
