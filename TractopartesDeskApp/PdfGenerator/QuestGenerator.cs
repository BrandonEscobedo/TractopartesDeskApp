using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;
namespace TractopartesDeskApp.PdfGenerator
{
    public class QuestGenerator
    {
    public void GenerarPDF()
        {
            Document.Create(document =>
              {
                  document.Page(page =>
                  {

                  });
              }).ShowInPreviewer();

        }

    }
}
