using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Data
{
    public class DataRepository
    {
        static DataRepository()
        {
#if DEBUG
            string connectionString = "metadata=res://*/Chinook.csdl|res://*/Chinook.ssdl|res://*/Chinook.msl;provider=System.Data.SqlClient;provider connection string=\"data source=10.10.14.99;initial catalog=Chinook;persist security info=True;user id=sa;password=3512;MultipleActiveResultSets=True;App=EntityFramework\"";
#else
            string connectionString = "metadata=res://*/Chinook.csdl|res://*/Chinook.ssdl|res://*/Chinook.msl;provider=System.Data.SqlClient;provider connection string=\"data source=10.10.14.100;initial catalog=Chinook;persist security info=True;user id=sa;password=3512;MultipleActiveResultSets=True;App=EntityFramework\"";
#endif
            DbContextFactory.Initialize(connectionString);
        }

        public static AlbumData Album { get; } = new AlbumData();
        public static ArtistData Artist { get; } = new ArtistData();
        public static CustomerData Customer { get; } = new CustomerData();
        public static EmployeeData Employee { get; } = new EmployeeData();
        public static GenreData Genre { get; } = new GenreData();
        public static InvoiceData Invoice { get; } = new InvoiceData();
        public static InvoiceLineData InvoiceLine { get; } = new InvoiceLineData();
        public static MediaTypeData MediaType { get; } = new MediaTypeData();
        public static PlaylistData Playlist { get; } = new PlaylistData();
        public static TrackData Track { get; } = new TrackData();


    }
}
