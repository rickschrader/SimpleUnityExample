using System;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using Microsoft.Practices.ServiceLocation;
using Contracts;

namespace SimpleUnityExample
{
    class Program
    {
        static void Main(string[] args)
        {

            var locator = new UnityServiceLocator(CreateConfiguredUnityContainer());
            ServiceLocator.SetLocatorProvider(() => locator);

            var s = "The result string says";

            var serviceV1 = ServiceLocator.Current.GetInstance<IStringMutatorV1>();
            Console.WriteLine("V1 returned:");
            Console.WriteLine(serviceV1.MutateString(s));

            Console.WriteLine();

            var serviceV2 = ServiceLocator.Current.GetInstance<IStringMutatorV2>();
            Console.WriteLine("V2 returned:");
            Console.WriteLine(serviceV2.MutateString(s));

            //Wait for key press to terminate
            Console.ReadLine();

        }

        private static IUnityContainer CreateConfiguredUnityContainer()
        {
            IUnityContainer container = new UnityContainer();
            
            // (optional) provide default mappings programmatically
            //container.RegisterType<IStringMutatorV1, Implementation1.ImplementationV1>();
            //container.RegisterType<IStringMutatorV2, Implementation2.ImplementationV2>();

            // (optional) load static config from the *.xml file
            container.LoadConfiguration();

            return container;
        }

    }
}
