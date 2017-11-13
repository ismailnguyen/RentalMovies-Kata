using NFluent;
using NUnit.Framework;

namespace RentalMovies_Kata.Tests
{
    public class CustomerTest
    {
        [Test]
        public void Should_Print_Statement_For_()
        {
            // GIVEN
            var customer = new Customer("toto");
            var movie = new Movie("Transformers", Movie.NewRelease);
            var rental = new Rental(movie, 1);
            customer.AddRental(rental);

            // WHEN
            var statement = customer.Statement();

            // THEN
            Check.That(statement).IsEqualTo("Rental Record for toto\n" +
                "\tTransformers\t3\n" + 
                "Amount owed is 3\n" + 
                "You earned 1 frequent renter points");
        }
    }
}
