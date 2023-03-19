﻿using ContactInfoManagementSystem.Models;

namespace ContactInfoManagementSystem.Data
{
    public class Query
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Superhero> GetSuperheroes([Service] ApplicationDbContext context) =>
            context.Superheroes;

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Movie> GetMovies([Service] ApplicationDbContext context) =>
            context.Movies;

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Superpower> GetSuperpowers([Service] ApplicationDbContext context) =>
            context.Superpowers;

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<ContactInfo> GetContactInfo([Service] ApplicationDbContext context) =>
            context.ContactInfos;
    }
}
