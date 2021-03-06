﻿using NFluent;
using NUnit.Framework;

namespace RentalMovies_Kata.Tests
{
    public class CustomerTest
    {
        [Test]
        public void Should_Print_Statement_For_Regular_Movie_Rental_For_Less_Than_2_Days()
        {
            // GIVEN
            var customer = new Customer("toto");
            var movie = new Movie("Diner de cons", Movie.Regular);
            var rental = new Rental(movie, 1);
            customer.AddRental(rental);

            // WHEN
            var statement = customer.Statement();

            // THEN
            Check.That(statement).IsEqualTo("Rental Record for toto\n" +
                "\tDiner de cons\t2\n" +
                "Amount owed is 2\n" +
                "You earned 1 frequent renter points");
        }

        [Test]
        public void Should_Print_Statement_For_Regular_Movie_Rental_For_More_Than_2_Days()
        {
            // GIVEN
            var customer = new Customer("toto");
            var movie = new Movie("Diner de cons", Movie.Regular);
            var rental = new Rental(movie, 3);
            customer.AddRental(rental);

            // WHEN
            var statement = customer.Statement();

            // THEN
            Check.That(statement).IsEqualTo("Rental Record for toto\n" +
                "\tDiner de cons\t3.5\n" +
                "Amount owed is 3.5\n" +
                "You earned 1 frequent renter points");
        }

        [Test]
        public void Should_Print_Statement_For_NewRelease_Movie_Rental_For_Less_Than_1_Day()
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

        [Test]
        public void Should_Print_Statement_For_NewRelease_Movie_Rental_For_More_Than_1_Day()
        {
            // GIVEN
            var customer = new Customer("toto");
            var movie = new Movie("Transformers", Movie.NewRelease);
            var rental = new Rental(movie, 2);
            customer.AddRental(rental);

            // WHEN
            var statement = customer.Statement();

            // THEN
            Check.That(statement).IsEqualTo("Rental Record for toto\n" +
                "\tTransformers\t6\n" +
                "Amount owed is 6\n" +
                "You earned 2 frequent renter points");
        }

        [Test]
        public void Should_Print_Statement_For_Children_Movie_Rental_For_Less_Than_3_Days()
        {
            // GIVEN
            var customer = new Customer("toto");
            var movie = new Movie("Pokemon", Movie.Children);
            var rental = new Rental(movie, 1);
            customer.AddRental(rental);

            // WHEN
            var statement = customer.Statement();

            // THEN
            Check.That(statement).IsEqualTo("Rental Record for toto\n" +
                "\tPokemon\t1.5\n" +
                "Amount owed is 1.5\n" +
                "You earned 1 frequent renter points");
        }

        [Test]
        public void Should_Print_Statement_For_Children_Movie_Rental_For_More_Than_3_Days()
        {
            // GIVEN
            var customer = new Customer("toto");
            var movie = new Movie("Pokemon", Movie.Children);
            var rental = new Rental(movie, 4);
            customer.AddRental(rental);

            // WHEN
            var statement = customer.Statement();

            // THEN
            Check.That(statement).IsEqualTo("Rental Record for toto\n" +
                "\tPokemon\t3\n" +
                "Amount owed is 3\n" +
                "You earned 1 frequent renter points");
        }
    }
}
