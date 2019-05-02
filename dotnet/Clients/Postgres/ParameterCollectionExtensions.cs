using System;
using System.Data.Common;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Npgsql;

namespace Branch.Clients.Postgres
{
	public static class ParameterCollectionExtensions
	{
		public static void AddWithValueOrNull<T>(this NpgsqlParameterCollection parameters, string name, T value)
		{
			var bullshitValue = ((object)value) ?? DBNull.Value;

			parameters.AddWithValue(name, bullshitValue);
		}

		public static void AddWithValueAsEnum(this NpgsqlParameterCollection parameters, string name, string value, string enumName)
		{
			parameters.Add(new NpgsqlParameter
			{
				ParameterName = name,
				Value = value,
				DataTypeName = enumName,
			});
		}
	}
}
