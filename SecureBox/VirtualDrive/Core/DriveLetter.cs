using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace VirtualDrive.Core
{
    public static class DriveLetter
    {
        public static string UnusedDriveLetter()
        {
            var validLetters = Enumerable.Range('A', 'Z').Select(c => (char) c).ToList();

            var usedDriveLetters = UsedDriveLetters();

            foreach (char letter in validLetters)
            {
                if (!usedDriveLetters.Contains(letter))
                    return letter.ToString();
            }

            throw new ArgumentException("");
        }

        private static List<char> UsedDriveLetters()
        {
            return DriveInfo.GetDrives().Select(s => s.Name[0]).ToList();
        }
    }
}