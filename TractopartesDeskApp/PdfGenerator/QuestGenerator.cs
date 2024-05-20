using System;
using System.Collections.Generic;
using System.Linq;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;
using TractopartesDeskApp.Models;
namespace TractopartesDeskApp.PdfGenerator
{
    public class QuestGenerator
    {
        public string GenerarPDF(FacturaModel facturaModel)
        {
            QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;
            var outpath = $"C:/Users/jesus/OneDrive/Documentos/pdfs/Factura_{facturaModel.idventa}.pdf";
            Document.Create(document =>
            {
                document.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(17);
                    page.MarginBottom(30);
                    page.Header().ShowOnce().Row(row =>
                    {
                        row.ConstantItem(120).PaddingTop(-10).Height(80).Image("C:/Users/jesus/Downloads/Logo.png")
                        ;
                        row.RelativeItem().Column(column =>
                        {
                            column.Item().AlignCenter().Text("MVG").Bold().FontSize(14);
                            column.Item().AlignCenter().Text("Av.Mexico 446 Guadalupe N.L").Bold().FontSize(10);
                            column.Item().AlignCenter().Text("8118301311").FontSize(9);
                            column.Item().AlignCenter().Text("brandonescobedo1234@gmail.com").FontSize(9);
                        });
                        row.RelativeItem().Column(column =>
                        {
                            row.Spacing(10);
                            column.Item().BorderColor("#198B0E").Border(1).AlignCenter()
                            .Text("RFC 103049113HS1").Bold();
                            column.Item().Background("#198B0E").BorderColor("#198B0E")
                            .Border(1).AlignCenter().Text("Boleta de venta").FontColor(Colors.White);
                            column.Item().BorderColor("#198B0E")
                             .Border(1).AlignCenter().Text(facturaModel.idventa.ToString());
                            column.Item().BorderColor("#198B0E")
                           .Border(1).AlignCenter().Text($"Fecha de asunto:{facturaModel.FechaVenta}");

                        });
                    });
                    page.Content().PaddingVertical(10).Column(column =>
                    {
                        column.Item().Text("Datos del ciente").Underline().Bold();
                        column.Item().Text(txt =>
                        {
                            txt.Span("Nombre: ").SemiBold().FontSize(10);
                            txt.Span($"{facturaModel.userModel.nombres + " " + facturaModel.userModel.apellidopaterno
                                + " " + facturaModel.userModel.apellidomaterno}").FontSize(10);
                        });
                        column.Item().Text(txt =>
                        {
                            txt.Span("RFC: ").SemiBold().FontSize(10);
                            txt.Span($"{facturaModel.userModel.rfc}").FontSize(10);
                        });
                        column.Item().Text(txt =>
                        {
                            txt.Span("Dirrecion: ").SemiBold().FontSize(10);
                            txt.Span($"{facturaModel.userModel.direccion}").FontSize(10);
                        });
                        column.Item().Text(txt =>
                        {
                            txt.Span("Correo: ").SemiBold().FontSize(10);
                            txt.Span($"{facturaModel.userModel.email}").FontSize(10);

                        });
                        column.Item().Text(txt =>
                        {
                            txt.Span("Telefono: ").SemiBold().FontSize(10);
                            txt.Span($"{facturaModel.userModel.telefono1}").FontSize(10);

                        });

                        column.Item().LineHorizontal(0.8f);
                        column.Item().Table(table =>
                        {
                            table.ColumnsDefinition(column =>
                            {
                                column.RelativeColumn(3);
                                column.RelativeColumn();
                                column.RelativeColumn();
                                column.RelativeColumn();
                            });
                            table.Header(header =>
                            {
                                header.Cell().Background("#198B0E").Padding(2).Text("Producto").FontColor(Colors.White);
                                header.Cell().Background("#198B0E").Padding(2).Text("Precio Unitario").FontColor(Colors.White); ;
                                header.Cell().Background("#198B0E").Padding(2).Text("Cantidad").FontColor(Colors.White); ; ;
                                header.Cell().Background("#198B0E").Padding(2).Text("Precio total").FontColor(Colors.White); ; ;
                            });
                            foreach (var producto in facturaModel.Productos)
                            {
                                decimal totalProducto = producto._P_cantidad * producto.P_precioventa;
                                table.Cell().BorderBottom(0.5f).BorderColor("#E1E3E1")
                                .Padding(2).Text(producto.P_productonombre).FontSize(11);
                                table.Cell().BorderBottom(0.5f).BorderColor("#E1E3E1")
                              .Padding(2).Text(producto.P_precioventa.ToString()).FontSize(11);
                                table.Cell().BorderBottom(0.5f).BorderColor("#E1E3E1")
                              .Padding(2).Text(producto._P_cantidad.ToString()).FontSize(11);
                                table.Cell().BorderBottom(0.5f).BorderColor("#E1E3E1")
                              .Padding(2).Text(totalProducto.ToString()).FontSize(11);
                            }
                        });
                        column.Item().Padding(20).AlignRight().Text($"Total:{facturaModel.Total}").FontSize(15);

                        column.Item().Background("#F2F2F2").Padding(10).Column(col1 =>
                        {
                            col1.Item().Text(txt =>
                            {
                                txt.Span("Garantias:").FontSize(13).SemiBold();
                                col1.Spacing(5);
                                txt.Span(Placeholders.LoremIpsum()).FontSize(13);
                            });
                        });
                        column.Spacing(5);
                    });

                    page.Footer().AlignRight()
                    .Text(txt =>
                    {
                        txt.Span("Pagina ").FontSize(10);
                        txt.CurrentPageNumber().FontSize(10);
                        txt.Span(" de ").FontSize(10);
                        txt.TotalPages().FontSize(10);
                    });

                });
            }).GeneratePdf(outpath);
            return outpath;
        }
    }
}
