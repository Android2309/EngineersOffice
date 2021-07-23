using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace EngineersOffice_WpfDesktopClient
{
    public static class Extensions
    {
        public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> e)
        {
            ObservableCollection<T> t = new ObservableCollection<T>();
            foreach (var item in e)
            {
                t.Add(item);
            }
            return t;
        }
    }
}
