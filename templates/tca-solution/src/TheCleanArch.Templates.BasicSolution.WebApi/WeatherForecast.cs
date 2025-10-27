// Copyright (c) TheCleanArch.Templates.BasicSolution Team. All rights reserved.
#if (LicenseIsPrivate)
// This file is part of TheCleanArch.Templates.BasicSolution and is private code.
#else
// This file is part of TheCleanArch.Templates.BasicSolution and is licensed under the terms described in the LICENSE file.
#endif

namespace TheCleanArch.Templates.BasicSolution.WebApi;

public class WeatherForecast
{
    public DateOnly Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }
}