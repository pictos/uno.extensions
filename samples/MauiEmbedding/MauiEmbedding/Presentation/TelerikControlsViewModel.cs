using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiEmbedding.Presentation
{

    public partial class TelerikControlsViewModel : ObservableObject
    {
	    public List<Data> Datas = new()
	    {
		    new Data ( "India", "New Delhi"),
		    new Data ( "South Africa", "Cape Town"),
		    new Data ( "Nigeria", "Abuja" ),
		    new Data ( "Singapore", "Singapore" )
	    };
    }

    public record Data(string Country, string Capital);

}
