using Application.Books.Mutations;
using Application.Books.Queries;
using Application.Feeds.Queries;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    //.AddQueryType<BookQuery>()
    .AddQueryType<FeedQuery>()
    .AddMutationType<BookMutations>();

var app = builder.Build();

app.MapGraphQL();

app.Run();

