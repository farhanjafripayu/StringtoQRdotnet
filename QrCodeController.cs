using Microsoft.AspNetCore.Mvc;
using QRCoder;
using System.Drawing;
using System.IO;

namespace QrCodeGenerator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QrCodeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            string url = "https://test.payumoney.com/url/MIrl4LrTdk6F";

            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(url, QRCodeGenerator.ECCLevel.Q))
                {
                    using (QRCode qrCode = new QRCode(qrCodeData))
                    {
                        using (Bitmap qrCodeImage = qrCode.GetGraphic(20))
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                qrCodeImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                                byte[] byteImage = ms.ToArray();
                                return File(byteImage, "image/png");
                            }
                        }
                    }
                }
            }
        }
    }
}

