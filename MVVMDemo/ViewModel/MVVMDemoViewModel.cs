using System;
using MVVMDemo.Model;

namespace MVVMDemo.ViewModel {
   public class MVVMDemoViewModel {

      public string FullName { get; }

      public MVVMDemoViewModel( Person person ) {
         FullName = $"{person.FirstName} {person.LastName}";
      }
   }
}
