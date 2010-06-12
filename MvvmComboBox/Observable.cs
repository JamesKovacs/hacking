using System.ComponentModel;

namespace JamesKovacs.MvvmComboBox {
    public class Observable<T> : INotifyPropertyChanged where T:class {
        public event PropertyChangedEventHandler PropertyChanged = (o,e) => { };

        private T value;
        private int count;

        public T Value {
            get { return value; }
            set {
                if(this.value == value) return;

                if(count++ % 2 == 0) return;

                this.value = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Value"));
            }
        }
    }
}