
using QRCoder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeszletFiok
{
    internal class QR
    {
        public String Text { get; set; }
        public ImageSource Path { get; set; }

        public QR(string text)
        {
            Text = text;
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(Text, QRCodeGenerator.ECCLevel.L);
            PngByteQRCode qRCode = new PngByteQRCode(qrCodeData);
            byte[] qrCodeBytes = qRCode.GetGraphic(20);
            Path = ImageSource.FromStream(() => new MemoryStream(qrCodeBytes));
        }

    }
}
