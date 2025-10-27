// Copyright (c) TheCleanArch.Templates.BasicSolution Team. All rights reserved.
#if (LicenseIsPrivate)
// This file is part of TheCleanArch.Templates.BasicSolution and is private code.
#else
// This file is part of TheCleanArch.Templates.BasicSolution and is licensed under the terms described in the LICENSE file.
#endif

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();