using Gemstone.Classes.DTO;
using Gemstone.Definitions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Gemstone.Classes.Saving
{
    public class DocumentSaver
    {
        private string BasePath => Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        /*----- Public Methods -----*/

        /// <summary>
        /// Writes a single gemstone to file.
        /// Overrides previous file
        /// </summary>
        public void SaveSingleGemstone(string filename, Gem gemstone)
        {
            var path = BasePath + StaticStrings.GemPath;

            try
            {
                var playerDoc = OpenDocument(filename, path, false);
                WriteToDocument(playerDoc, gemstone.PlayerDocumentStrings());
                playerDoc.Close();

                var GMDoc = OpenDocument("GM" + filename, path, false);
                WriteToDocument(GMDoc, gemstone.GMDocumentStrings());
                GMDoc.Close();
            }
            catch (Exception ex)
            {
                var message = "Error saving single gemstone => " + ex.Message;
                throw new InvalidOperationException(message, ex);
            }
        }

        public void SaveCurrency(string filename, Currency currency)
        {
            var path = BasePath + StaticStrings.CurrencyPath;

            try
            {
                var playerDoc = OpenDocument(filename, path);
                WriteToDocument(playerDoc, currency.DocumentStrings());
                playerDoc.Close();
            }
            catch (Exception ex)
            {
                var message = "Error saving currency => " + ex.Message;
                throw new InvalidOperationException(message, ex);
            }
        }

        public void SaveCoinpurses(string filename, List<Currency> coinpurses)
        {
            var path = BasePath + StaticStrings.CurrencyPath;

            try
            {
                var playerDoc = OpenDocument(filename, path);
                foreach (var purse in coinpurses)
                    WriteToDocument(playerDoc, purse.DocumentStrings());
                playerDoc.Close();

                var GMDoc = OpenDocument("GM" + filename, path);
                foreach (var purse in coinpurses)
                    WriteToDocument(GMDoc, purse.GMDocumentStrings());
                GMDoc.Close();
            }
            catch (Exception ex)
            {
                var message = "Error saving coinpurses => " + ex.Message;
                throw new InvalidOperationException(message, ex);
            }
        }

        public void SaveSingleWeapon(string filename, Weapon weapon)
        {
            var path = BasePath + StaticStrings.WeaponPath;

            try
            {
                var playerDoc = OpenDocument(filename, path, false);
                WriteToDocument(playerDoc, weapon.PlayerDocumentStrings());
                playerDoc.Close();
            }
            catch (Exception ex)
            {
                var message = "Error saving single weapon => " + ex.Message;
                throw new InvalidOperationException(message, ex);
            }
        }

        /*----- Private Methods -----*/

        private void WriteToDocument(StreamWriter document, List<string> writeLines)
        {
            foreach (var line in writeLines)
            {
                document.WriteLine(line);
            }

            document.WriteLine(string.Empty); // Empty Line for spacing while appending new lines
        }

        private StreamWriter OpenDocument(string filename, string path, bool append = true)
        {
            try
            {
                ValidateFilename(filename);
                Directory.CreateDirectory(path); // Creates directory if needed - Does nothing if not needed.

                return new StreamWriter(path + filename, append: append);
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

            var n = Path.GetInvalidFileNameChars();
            if (filename.Any(x => Path.GetInvalidFileNameChars().Contains(x)))
                throw new InvalidDataException("Filename contains invalid characters");
        }
    }
}
