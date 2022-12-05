using Microsoft.Extensions.DependencyInjection;
using QualityShims;
using QualityShims.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QIReport.Factories
{
    public class FormFactory
    {
        private static IServiceProvider _serviceProvider;

        public void SetServiceProvider(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public T CreateForm<T>() where T : Form
        {
            return _serviceProvider.GetRequiredService<T>();
        }
    }
}
