using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace QuidditchWPF
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// OnStartUp redefinie.
        /// </summary>
        /// <param name="e">Evenement ???</param>
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            DispatcherUnhandledException += App_DispatcherUnhandledException;
        }

        /// <summary>
        /// Methode ou se place le corps de la gestion des exception.
        /// </summary>
        /// <param name="sender">L'objet qui a envoyer l'exeption.</param>
        /// <param name="e">Evenement ???</param>
        void App_DispatcherUnhandledException(Object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            // ici votre gestion des exeption
        }
    }
}
