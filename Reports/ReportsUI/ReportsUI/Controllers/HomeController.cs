using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReportsUI.DBFirst;
using ReportsUI.Models;

namespace ReportsUI.Controllers
{
    public class HomeController : Controller
    {
        private HukukcrmprodContext _context = new HukukcrmprodContext();
        public async Task<IActionResult> Index()
        {
            var cft = await _context.CozumOrtagiDosyaTaraflars.Where(x => x.TarafSifati == "Alacaklı").ToListAsync();
            var cod = await _context.CozumOrtagiDosyas
                .Include(x => x.Cozumortagi)
                .ToListAsync();
            var col = await _context.CozumOrtaklaris.ToListAsync();
            var dos = await _context.DosyaDurumlars.ToListAsync();
            var uyes = await _context.Uyelers.ToListAsync();
            var dip = await _context.DosyaTipleris.ToListAsync();
            CozumOrtagıViewModel cozumOrtagıViewModel = new() { CozumOrtagiDosyas = cod, CozumOrtaklaris = col, DosyaDurumlars = dos };
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.AddWorksheet();
                worksheet.Cell(1, 1).Value = "Dosya Numarası";
                worksheet.Cell(1, 2).Value = "Dosya Adı";
                worksheet.Cell(1, 3).Value = "Çözüm Ortağı";
                worksheet.Cell(1, 4).Value = "Alacaklı";
                worksheet.Cell(1, 5).Value = "Borç Tutarı";
                worksheet.Cell(1, 6).Value = "Para Birimi";
                worksheet.Cell(1, 7).Value = "Faiz";
                worksheet.Cell(1, 8).Value = "Komisyon";
                worksheet.Cell(1, 9).Value = "KDV";
                worksheet.Cell(1, 10).Value = "Oluşturulma Tarihi";
                worksheet.Cell(1, 11).Value = "Oluşturan Personel";
                worksheet.Cell(1, 12).Value = "Dosya Tipi";
                worksheet.Cell(1, 13).Value = "Dosya Durumu";

                int RowCount = 2;
                foreach (var item in cod)
                {
                    worksheet.Cell(RowCount, 1).Value = item.DosyaNo;
                    worksheet.Cell(RowCount, 2).Value = item.DosyaAdi;
                    foreach (var colist in col.Where(x=>x.Id==item.CozumortagiId))
                    {
                        worksheet.Cell(RowCount, 3).Value = colist.CozumortagiAdi;
                    }
                    foreach (var taraf in cft.Where(x => x.TarafId == item.CozumortagiId && x.DosyaId==item.Id))
                    {
                        foreach (var colist in col.Where(x => x.Id == taraf.Id))
                        {
                            worksheet.Cell(RowCount, 4).Value = colist.CozumortagiAdi;
                        }
                    }
                    worksheet.Cell(RowCount, 5).Value = item.BorcTutari;
                    worksheet.Cell(RowCount, 6).Value = item.ParaBirimi;
                    worksheet.Cell(RowCount, 7).Value = item.Faiz;
                    worksheet.Cell(RowCount, 8).Value = item.Komisyon;
                    worksheet.Cell(RowCount, 9).Value = item.Kdv;
                    worksheet.Cell(RowCount, 10).Value = item.OlusturulmaTarihi;
                    foreach (var op in uyes.Where(x=>x.Id==item.OlusturanPersonel))
                    {
                        worksheet.Cell(RowCount, 11).Value = op.KullaniciAdi;
                    }
                    foreach (var dt in dip.Where(x=>x.Id==item.DosyaTipi))
                    {
                        worksheet.Cell(RowCount, 12).Value = dt.DosyaTipi;
                    }
                    worksheet.Cell(RowCount, 13).Value = item.DosyaDurumu;
                    RowCount++;

                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Dosyalar.xlsx");
                }
            }
        }
    }
}
