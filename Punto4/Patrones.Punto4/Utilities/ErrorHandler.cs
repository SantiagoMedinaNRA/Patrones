using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4.TaskManager.Utilities
{
    static class ErrorHandler
    {
        public static void HandleException(Exception ex, string context)
        {
            MessageHandler.ShowError($"Error en {context}: {ex.Message}");
        }
    }
}
