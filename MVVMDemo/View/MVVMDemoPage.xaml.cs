using MVVMDemo.Model;
using MVVMDemo.ViewModel;
using Xamarin.Forms;

namespace MVVMDemo {
   public partial class MVVMDemoPage : ContentPage {
      MVVMDemoViewModel vm;
      Person person;

      public MVVMDemoPage() {
         InitializeComponent();
         person = new Person();
         person.FirstName = "Jesse";
         person.LastName = "Liberty";
         person.email = "jesseliberty@gmail.com";
         vm = new MVVMDemoViewModel( person );
         BindingContext = vm;
      }
   }
}
