using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        private static Size GetConsoleFontSize()
        {
            // getting the console out buffer handle
            IntPtr outHandle = CreateFile("CONOUT$", GENERIC_READ | GENERIC_WRITE,
                FILE_SHARE_READ | FILE_SHARE_WRITE,
                IntPtr.Zero,
                OPEN_EXISTING,
                0,
                IntPtr.Zero);
            int errorCode = Marshal.GetLastWin32Error();
            if (outHandle.ToInt32() == INVALID_HANDLE_VALUE)
            {
                throw new IOException("Unable to open CONOUT$", errorCode);
            }

            ConsoleFontInfo cfi = new ConsoleFontInfo();
            if (!GetCurrentConsoleFont(outHandle, false, cfi))
            {
                throw new InvalidOperationException("Unable to get font information.");
            }

            return new Size(cfi.dwFontSize.X, cfi.dwFontSize.Y);
        }
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetConsoleWindow();

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr CreateFile(
            string lpFileName,
            int dwDesiredAccess,
            int dwShareMode,
            IntPtr lpSecurityAttributes,
            int dwCreationDisposition,
            int dwFlagsAndAttributes,
            IntPtr hTemplateFile);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool GetCurrentConsoleFont(
            IntPtr hConsoleOutput,
            bool bMaximumWindow,
            [Out][MarshalAs(UnmanagedType.LPStruct)] ConsoleFontInfo lpConsoleCurrentFont);

        [StructLayout(LayoutKind.Sequential)]
        internal class ConsoleFontInfo
        {
            internal int nFont;
            internal Coord dwFontSize;
        }

        [StructLayout(LayoutKind.Explicit)]
        internal struct Coord
        {
            [FieldOffset(0)]
            internal short X;
            [FieldOffset(2)]
            internal short Y;
        }

        private const int GENERIC_READ = unchecked((int)0x80000000);
        private const int GENERIC_WRITE = 0x40000000;
        private const int FILE_SHARE_READ = 1;
        private const int FILE_SHARE_WRITE = 2;
        private const int INVALID_HANDLE_VALUE = -1;
        private const int OPEN_EXISTING = 3;
    
        static void Main(string[] args)
        {
            ServiceReference1.WebService1SoapClient Stub = new ServiceReference1.WebService1SoapClient();
            
        
        Console.WriteLine("Vous pousedez dêja un compte ? ( Merci de répondre oui ou non ");
                String rep = Console.ReadLine();
                if (rep == "non")
                {
                    Console.WriteLine("Création de compte :");
                    Console.WriteLine("saisissez votre identifiant :");
                    String id = Console.ReadLine();
                    Console.WriteLine("saisissez votre Mot de passe");
                    String MDP = Console.ReadLine();
                    Stub.signUp(id, MDP);
                    Console.WriteLine("Compte crée avec succès ");
                }
            bool x = true;
            while (x)
            {
                Console.WriteLine("Recherche d'hotel :");
                Console.WriteLine("pour effectué une recherche veuillez saisir les informations si dessus ");

                Console.WriteLine("Quel est la ville souhaitée ? ");

                string ville = Console.ReadLine();
                Console.WriteLine("Quel est le nb d'etoiles ? ");

                int stars = int.Parse(Console.ReadLine());

                Console.WriteLine("Voici la liste des hotels disponible:");
                for (int i = 0; i < Stub.RechercherIdHotel(ville, stars).Length; i++)
                {
                    Console.WriteLine(Stub.RechercherIdHotel(ville, stars).ElementAt(i));

                }


                Console.WriteLine("Quel est le nombre de personnes  ? ");

                int nbdepers = int.Parse(Console.ReadLine());


                Console.WriteLine("Quel est la date d'arrivée (au format jj/mm/aaaa) ");

                DateTime dateArrivee = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("Quel est la date de départ (au format jj/mm/aaaa) ");

                DateTime dateDepart = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine(dateDepart);

                Console.WriteLine("Quel est le prix min ? ");

                int prixMin = int.Parse(Console.ReadLine());


                Console.WriteLine("Quel est le prix max ? ");

                int prixMax = int.Parse(Console.ReadLine());

                Console.WriteLine("Quell est id de l'hotel que vous voulez ? ");
                int idhotel = int.Parse(Console.ReadLine());
                Console.WriteLine("Identification :");
                Console.WriteLine("saisissez votre identifiant :");
                String id1 = Console.ReadLine();
                Console.WriteLine("saisissez votre Mot de passe");
                String MDP1 = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                if(Stub.Rechercher(ville, dateArrivee, dateDepart, prixMin, prixMax, stars, nbdepers, id1, MDP1, idhotel).Length>0)
                {
                    for (int i = 0; i < Stub.Rechercher(ville, dateArrivee, dateDepart, prixMin, prixMax, stars, nbdepers, id1, MDP1, idhotel).Length; i++)
                        Console.WriteLine(Stub.Rechercher(ville, dateArrivee, dateDepart, prixMin, prixMax, stars, nbdepers, id1, MDP1, idhotel).ElementAt(i));
                    Size imageSize = new Size(20, 10); // desired image size in characters

                    // draw some placeholders
                    

                    using (Graphics g = Graphics.FromHwnd(GetConsoleWindow()))
                    {
                        using (Image image = (Bitmap)((new ImageConverter()).ConvertFrom(Stub.GetImageFile(idhotel,0))))
                        {
                            Size fontSize = GetConsoleFontSize();

                            // translating the character positions to pixels
                            Rectangle imageRect = new Rectangle(
                                0 * fontSize.Width,
                               16 * fontSize.Height,
                                imageSize.Width * fontSize.Width,
                                imageSize.Height * fontSize.Height);
                            g.DrawImage(image, imageRect);
                        }
                    }

                    using (Graphics g = Graphics.FromHwnd(GetConsoleWindow()))
                    {
                        using (Image image = (Bitmap)((new ImageConverter()).ConvertFrom(Stub.GetImageFile(idhotel, 12))))
                        {
                            Size fontSize = GetConsoleFontSize();

                            // translating the character positions to pixels
                            Rectangle imageRect = new Rectangle(
                               30 *fontSize.Width,
                               16 * fontSize.Height,
                                imageSize.Width * fontSize.Width,
                                imageSize.Height * fontSize.Height);
                            g.DrawImage(image, imageRect);
                        }
                    }
                    Console.WriteLine("Si vous voulez confirmer votre reservation tapez l'identifiant Unique de votre offre :");
                    int idoffre = int.Parse(Console.ReadLine());
                    Console.WriteLine("Saisissez le nom de la personne principale à	héberger :");
                    String nom = Console.ReadLine();
                    Console.WriteLine("Saisissez le prenom de la personne principale à	héberger :");
                    String prenom = Console.ReadLine();

                    Console.WriteLine(Stub.reserFinal(idoffre, idhotel, dateArrivee, dateDepart,nom,prenom));
                }
                else
                {
                    Console.WriteLine("Aucune offre Disponible");

                }


               
                Console.WriteLine("Voulez vous effectué une nouvelle recherche ?");
                String rep1 = Console.ReadLine();
                if (rep1 == "non")
                {
                    x = false;
                }

            }
        }
    }
}
