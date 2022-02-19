using System.Collections.Generic;
using udemy.Models;

namespace udemy.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
