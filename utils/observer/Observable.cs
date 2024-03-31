using System;
using System.Collections.Generic;

namespace ProjectCS.utils.observer
{
    public interface Observable
    {
        void registerObserver(Observer o);
        void removeObserver(Observer o);
        void notifyAllObserver();
    }
}