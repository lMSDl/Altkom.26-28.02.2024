using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPatterns.Behavioral.Memento
{
    internal class AutoCaretaker<T> : Caretaker<T> where T : ICloneable, IRestorable<T>, INotifyPropertyChanged
    {
        public AutoCaretaker(T originator) : base(originator)
        {
            originator.PropertyChanged += Originator_PropertyChanged;
        }

        private void Originator_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            SaveState();
        }

        /*protected override void RestoreState(Memento<T> memento)
        {
            originator.PropertyChanged -= Originator_PropertyChanged;
            base.RestoreState(memento);
            originator.PropertyChanged += Originator_PropertyChanged;
        }*/
    }
}
