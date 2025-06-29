﻿using Microsoft.AspNetCore.Http;
using System.Net.NetworkInformation;
using System.Text.Json;
using Online_Store.Models;
using Microsoft.AspNetCore.Mvc;

public static class SessionExtensions
{
    public static void SetObjectAsJson(this ISession session, string key, object value)
    {
        session.SetString(key, JsonSerializer.Serialize(value));
    }

    public static T? GetObjectFromJson<T>(this ISession session, string key)
    {
        var value = session.GetString(key);
        return value == null ? default : JsonSerializer.Deserialize<T>(value);
    }
}

