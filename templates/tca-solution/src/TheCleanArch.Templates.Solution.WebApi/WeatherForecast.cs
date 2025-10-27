// Copyright (c) TheCleanArch.Templates.Solution Team. All rights reserved.
#if (LicenseIsPrivate)
// This file is part of TheCleanArch.Templates.Solution and is private code.
#else
// This file is part of TheCleanArch.Templates.Solution and is licensed under the terms described in the LICENSE file.
#endif

namespace TheCleanArch.Templates.Solution.WebApi;

public class WeatherForecast
{
    public DateOnly Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }
}