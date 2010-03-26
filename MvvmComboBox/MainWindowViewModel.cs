using System.Collections.Generic;

namespace MvvmComboBox {
    public class MainWindowViewModel {
        public MainWindowViewModel() {
            TextBoxText = new Observable<string>();
            ComboBoxSelectedItem = new Observable<string>();
        }

        public Observable<string> TextBoxText { get; set; }
        public Observable<string> ComboBoxSelectedItem { get; set; }
        public IEnumerable<string> ComboBoxItems {
            get {
                yield return "One";
                yield return "Two";
                yield return "Three";
                yield return "Four";
                yield return "Five";
            }
        }
    }
}