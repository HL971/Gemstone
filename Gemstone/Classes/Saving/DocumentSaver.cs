using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemstone.Classes.Saving
{
    class DocumentSaver
    {
        // Public Methods

        // Private Methods

        private StreamWriter OpenDocument(string filename, string path)
        {
            try
            {
                ValidateFilename(filename);

                return new StreamWriter(path + filename);
            }
            catch (Exception ex)
            {
                var message = "Error Opening Document => " + ex.Message;
                throw new InvalidOperationException(message, ex);
            }
        }

        private void ValidateFilename(string filename)
        {
            if (filename == null)
                throw new ArgumentNullException("Filename was null");

            if (filename.Trim().Length == 0)
                throw new InvalidDataException("Filename is empty, or only contains whitespace");

            if (filename.Any(x => Path.GetInvalidFileNameChars().ToString().Contains(x)))
                throw new InvalidDataException("Filename contains invalid characters");
        }
    }
}
