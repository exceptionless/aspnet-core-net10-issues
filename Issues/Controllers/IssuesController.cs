using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Foundatio.Repositories.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Issues.Controllers;

[ApiController]
[Route("[controller]")]
public class IssuesController : ControllerBase
{
    private readonly ILogger<IssuesController> _logger;

    public IssuesController(ILogger<IssuesController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
            })
            .ToArray();
    }

    /// <summary>
    /// NOTE: This is also missing IAggregate and all other dependent types in open API gen
    /// </summary>
    [HttpGet("problem-details-serialization-issue")]
    public ActionResult<CountResult> ProblemDetailsSerializationIssueAsync()
    {
        /* lang=json */
        const string json =
            "{\"total\":2,\"aggregations\":{\"cardinality_stack\":{\"value\":2.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":2.0,\"data\":{\"@type\":\"value\"}},\"terms_first\":{\"items\":[{\"key\":1,\"key_as_string\":\"true\",\"total\":1,\"data\":{\"@type\":\"object\"}}],\"data\":{\"@type\":\"bucket\"},\"total\":0},\"date_date\":{\"items\":[{\"date\":\"2025-05-17T23:24:00Z\",\"key\":1747524240000.0,\"key_as_string\":\"2025-05-17T23:24:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-18T00:21:00Z\",\"key\":1747527660000.0,\"key_as_string\":\"2025-05-18T00:21:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-18T01:18:00Z\",\"key\":1747531080000.0,\"key_as_string\":\"2025-05-18T01:18:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-18T02:15:00Z\",\"key\":1747534500000.0,\"key_as_string\":\"2025-05-18T02:15:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-18T03:12:00Z\",\"key\":1747537920000.0,\"key_as_string\":\"2025-05-18T03:12:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-18T04:09:00Z\",\"key\":1747541340000.0,\"key_as_string\":\"2025-05-18T04:09:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-18T05:06:00Z\",\"key\":1747544760000.0,\"key_as_string\":\"2025-05-18T05:06:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-18T06:03:00Z\",\"key\":1747548180000.0,\"key_as_string\":\"2025-05-18T06:03:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-18T07:00:00Z\",\"key\":1747551600000.0,\"key_as_string\":\"2025-05-18T07:00:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-18T07:57:00Z\",\"key\":1747555020000.0,\"key_as_string\":\"2025-05-18T07:57:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-18T08:54:00Z\",\"key\":1747558440000.0,\"key_as_string\":\"2025-05-18T08:54:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-18T09:51:00Z\",\"key\":1747561860000.0,\"key_as_string\":\"2025-05-18T09:51:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-18T10:48:00Z\",\"key\":1747565280000.0,\"key_as_string\":\"2025-05-18T10:48:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-18T11:45:00Z\",\"key\":1747568700000.0,\"key_as_string\":\"2025-05-18T11:45:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-18T12:42:00Z\",\"key\":1747572120000.0,\"key_as_string\":\"2025-05-18T12:42:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-18T13:39:00Z\",\"key\":1747575540000.0,\"key_as_string\":\"2025-05-18T13:39:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-18T14:36:00Z\",\"key\":1747578960000.0,\"key_as_string\":\"2025-05-18T14:36:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-18T15:33:00Z\",\"key\":1747582380000.0,\"key_as_string\":\"2025-05-18T15:33:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-18T16:30:00Z\",\"key\":1747585800000.0,\"key_as_string\":\"2025-05-18T16:30:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-18T17:27:00Z\",\"key\":1747589220000.0,\"key_as_string\":\"2025-05-18T17:27:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-18T18:24:00Z\",\"key\":1747592640000.0,\"key_as_string\":\"2025-05-18T18:24:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-18T19:21:00Z\",\"key\":1747596060000.0,\"key_as_string\":\"2025-05-18T19:21:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-18T20:18:00Z\",\"key\":1747599480000.0,\"key_as_string\":\"2025-05-18T20:18:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-18T21:15:00Z\",\"key\":1747602900000.0,\"key_as_string\":\"2025-05-18T21:15:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-18T22:12:00Z\",\"key\":1747606320000.0,\"key_as_string\":\"2025-05-18T22:12:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-18T23:09:00Z\",\"key\":1747609740000.0,\"key_as_string\":\"2025-05-18T23:09:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-19T00:06:00Z\",\"key\":1747613160000.0,\"key_as_string\":\"2025-05-19T00:06:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-19T01:03:00Z\",\"key\":1747616580000.0,\"key_as_string\":\"2025-05-19T01:03:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-19T02:00:00Z\",\"key\":1747620000000.0,\"key_as_string\":\"2025-05-19T02:00:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-19T02:57:00Z\",\"key\":1747623420000.0,\"key_as_string\":\"2025-05-19T02:57:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-19T03:54:00Z\",\"key\":1747626840000.0,\"key_as_string\":\"2025-05-19T03:54:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-19T04:51:00Z\",\"key\":1747630260000.0,\"key_as_string\":\"2025-05-19T04:51:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-19T05:48:00Z\",\"key\":1747633680000.0,\"key_as_string\":\"2025-05-19T05:48:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-19T06:45:00Z\",\"key\":1747637100000.0,\"key_as_string\":\"2025-05-19T06:45:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-19T07:42:00Z\",\"key\":1747640520000.0,\"key_as_string\":\"2025-05-19T07:42:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-19T08:39:00Z\",\"key\":1747643940000.0,\"key_as_string\":\"2025-05-19T08:39:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-19T09:36:00Z\",\"key\":1747647360000.0,\"key_as_string\":\"2025-05-19T09:36:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-19T10:33:00Z\",\"key\":1747650780000.0,\"key_as_string\":\"2025-05-19T10:33:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-19T11:30:00Z\",\"key\":1747654200000.0,\"key_as_string\":\"2025-05-19T11:30:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-19T12:27:00Z\",\"key\":1747657620000.0,\"key_as_string\":\"2025-05-19T12:27:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-19T13:24:00Z\",\"key\":1747661040000.0,\"key_as_string\":\"2025-05-19T13:24:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-19T14:21:00Z\",\"key\":1747664460000.0,\"key_as_string\":\"2025-05-19T14:21:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-19T15:18:00Z\",\"key\":1747667880000.0,\"key_as_string\":\"2025-05-19T15:18:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-19T16:15:00Z\",\"key\":1747671300000.0,\"key_as_string\":\"2025-05-19T16:15:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-19T17:12:00Z\",\"key\":1747674720000.0,\"key_as_string\":\"2025-05-19T17:12:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-19T18:09:00Z\",\"key\":1747678140000.0,\"key_as_string\":\"2025-05-19T18:09:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-19T19:06:00Z\",\"key\":1747681560000.0,\"key_as_string\":\"2025-05-19T19:06:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-19T20:03:00Z\",\"key\":1747684980000.0,\"key_as_string\":\"2025-05-19T20:03:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-19T21:00:00Z\",\"key\":1747688400000.0,\"key_as_string\":\"2025-05-19T21:00:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-19T21:57:00Z\",\"key\":1747691820000.0,\"key_as_string\":\"2025-05-19T21:57:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-19T22:54:00Z\",\"key\":1747695240000.0,\"key_as_string\":\"2025-05-19T22:54:00.0000000Z\",\"total\":1,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":1.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":1.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-19T23:51:00Z\",\"key\":1747698660000.0,\"key_as_string\":\"2025-05-19T23:51:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-20T00:48:00Z\",\"key\":1747702080000.0,\"key_as_string\":\"2025-05-20T00:48:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-20T01:45:00Z\",\"key\":1747705500000.0,\"key_as_string\":\"2025-05-20T01:45:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-20T02:42:00Z\",\"key\":1747708920000.0,\"key_as_string\":\"2025-05-20T02:42:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-20T03:39:00Z\",\"key\":1747712340000.0,\"key_as_string\":\"2025-05-20T03:39:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-20T04:36:00Z\",\"key\":1747715760000.0,\"key_as_string\":\"2025-05-20T04:36:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-20T05:33:00Z\",\"key\":1747719180000.0,\"key_as_string\":\"2025-05-20T05:33:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-20T06:30:00Z\",\"key\":1747722600000.0,\"key_as_string\":\"2025-05-20T06:30:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-20T07:27:00Z\",\"key\":1747726020000.0,\"key_as_string\":\"2025-05-20T07:27:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-20T08:24:00Z\",\"key\":1747729440000.0,\"key_as_string\":\"2025-05-20T08:24:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-20T09:21:00Z\",\"key\":1747732860000.0,\"key_as_string\":\"2025-05-20T09:21:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-20T10:18:00Z\",\"key\":1747736280000.0,\"key_as_string\":\"2025-05-20T10:18:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-20T11:15:00Z\",\"key\":1747739700000.0,\"key_as_string\":\"2025-05-20T11:15:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-20T12:12:00Z\",\"key\":1747743120000.0,\"key_as_string\":\"2025-05-20T12:12:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-20T13:09:00Z\",\"key\":1747746540000.0,\"key_as_string\":\"2025-05-20T13:09:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-20T14:06:00Z\",\"key\":1747749960000.0,\"key_as_string\":\"2025-05-20T14:06:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-20T15:03:00Z\",\"key\":1747753380000.0,\"key_as_string\":\"2025-05-20T15:03:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-20T16:00:00Z\",\"key\":1747756800000.0,\"key_as_string\":\"2025-05-20T16:00:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-20T16:57:00Z\",\"key\":1747760220000.0,\"key_as_string\":\"2025-05-20T16:57:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-20T17:54:00Z\",\"key\":1747763640000.0,\"key_as_string\":\"2025-05-20T17:54:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-20T18:51:00Z\",\"key\":1747767060000.0,\"key_as_string\":\"2025-05-20T18:51:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-20T19:48:00Z\",\"key\":1747770480000.0,\"key_as_string\":\"2025-05-20T19:48:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-20T20:45:00Z\",\"key\":1747773900000.0,\"key_as_string\":\"2025-05-20T20:45:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-20T21:42:00Z\",\"key\":1747777320000.0,\"key_as_string\":\"2025-05-20T21:42:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-20T22:39:00Z\",\"key\":1747780740000.0,\"key_as_string\":\"2025-05-20T22:39:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-20T23:36:00Z\",\"key\":1747784160000.0,\"key_as_string\":\"2025-05-20T23:36:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-21T00:33:00Z\",\"key\":1747787580000.0,\"key_as_string\":\"2025-05-21T00:33:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-21T01:30:00Z\",\"key\":1747791000000.0,\"key_as_string\":\"2025-05-21T01:30:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-21T02:27:00Z\",\"key\":1747794420000.0,\"key_as_string\":\"2025-05-21T02:27:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-21T03:24:00Z\",\"key\":1747797840000.0,\"key_as_string\":\"2025-05-21T03:24:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-21T04:21:00Z\",\"key\":1747801260000.0,\"key_as_string\":\"2025-05-21T04:21:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-21T05:18:00Z\",\"key\":1747804680000.0,\"key_as_string\":\"2025-05-21T05:18:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-21T06:15:00Z\",\"key\":1747808100000.0,\"key_as_string\":\"2025-05-21T06:15:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-21T07:12:00Z\",\"key\":1747811520000.0,\"key_as_string\":\"2025-05-21T07:12:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-21T08:09:00Z\",\"key\":1747814940000.0,\"key_as_string\":\"2025-05-21T08:09:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-21T09:06:00Z\",\"key\":1747818360000.0,\"key_as_string\":\"2025-05-21T09:06:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-21T10:03:00Z\",\"key\":1747821780000.0,\"key_as_string\":\"2025-05-21T10:03:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-21T11:00:00Z\",\"key\":1747825200000.0,\"key_as_string\":\"2025-05-21T11:00:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-21T11:57:00Z\",\"key\":1747828620000.0,\"key_as_string\":\"2025-05-21T11:57:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-21T12:54:00Z\",\"key\":1747832040000.0,\"key_as_string\":\"2025-05-21T12:54:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-21T13:51:00Z\",\"key\":1747835460000.0,\"key_as_string\":\"2025-05-21T13:51:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-21T14:48:00Z\",\"key\":1747838880000.0,\"key_as_string\":\"2025-05-21T14:48:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-21T15:45:00Z\",\"key\":1747842300000.0,\"key_as_string\":\"2025-05-21T15:45:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-21T16:42:00Z\",\"key\":1747845720000.0,\"key_as_string\":\"2025-05-21T16:42:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-21T17:39:00Z\",\"key\":1747849140000.0,\"key_as_string\":\"2025-05-21T17:39:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-21T18:36:00Z\",\"key\":1747852560000.0,\"key_as_string\":\"2025-05-21T18:36:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-21T19:33:00Z\",\"key\":1747855980000.0,\"key_as_string\":\"2025-05-21T19:33:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-21T20:30:00Z\",\"key\":1747859400000.0,\"key_as_string\":\"2025-05-21T20:30:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-21T21:27:00Z\",\"key\":1747862820000.0,\"key_as_string\":\"2025-05-21T21:27:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-21T22:24:00Z\",\"key\":1747866240000.0,\"key_as_string\":\"2025-05-21T22:24:00.0000000Z\",\"total\":0,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":0.0,\"data\":{\"@type\":\"value\"}}}},{\"date\":\"2025-05-21T23:21:00Z\",\"key\":1747869660000.0,\"key_as_string\":\"2025-05-21T23:21:00.0000000Z\",\"total\":1,\"data\":{\"@type\":\"datehistogram\"},\"aggregations\":{\"cardinality_stack\":{\"value\":1.0,\"data\":{\"@type\":\"value\"}},\"sum_count\":{\"value\":1.0,\"data\":{\"@type\":\"value\"}}}}],\"data\":{\"@type\":\"bucket\"},\"total\":0}}}";
        return Ok(Newtonsoft.Json.JsonConvert.DeserializeObject<CountResult>(json));
    }
    
    /// <summary>
    /// NOTE: This is also missing IAggregate and all other dependent types in model gen.
    /// <response code="404">could not be found.</response>
    /// <response code="426">Upgrade, these are missing in open api.</response>
    /// </summary>
    [HttpGet("open-api-model-issue")]
    public ActionResult<SampleModel> OpenApiModelIssue()
    {
        return Ok(new SampleModel { ShouldHaveMinLength = "but doesn't" });
    }
    
    
    ///  <summary>
    ///  Submit event by POST
    ///  </summary>
    ///  <remarks>
    ///  You can create an event by posting any uncompressed or compressed (gzip or deflate) string or json object. If we know how to handle it
    ///  we will create a new event. If none of the JSON properties match the event object then we will create a new event and place your JSON
    ///  object into the events data collection.
    ///
    ///  You can also post a multi-line string. We automatically split strings by the \n character and create a new log event for every line.
    ///
    ///  Simple event:
    ///  <code>
    ///      { "message": "Exceptionless is amazing!" }
    ///  </code>
    ///
    ///  Simple log event with user identity:
    ///  <code>
    ///      {
    ///          "type": "log",
    ///          "message": "Exceptionless is amazing!",
    ///          "date":"2030-01-01T12:00:00.0000000-05:00",
    ///          "@user":{ "identity":"123456789", "name": "Test User" }
    ///      }
    ///  </code>
    ///
    ///  Multiple events from string content:
    ///  <code>
    ///      Exceptionless is amazing!
    ///      Exceptionless is really amazing!
    ///  </code>
    ///
    ///  Simple error:
    ///  <code>
    ///      {
    ///          "type": "error",
    ///          "date":"2030-01-01T12:00:00.0000000-05:00",
    ///          "@simple_error": {
    ///              "message": "Simple Exception",
    ///              "type": "System.Exception",
    ///              "stack_trace": "   at Client.Tests.ExceptionlessClientTests.CanSubmitSimpleException() in ExceptionlessClientTests.cs:line 77"
    ///          }
    ///      }
    ///  </code>
    ///  </remarks>
    ///  <param name="userAgent">The user agent that submitted the event.</param>
    ///  <response code="202">Accepted</response>
    ///  <response code="400">No project id specified and no default project was found.</response>
    ///  <response code="404">No project was found.</response>
    [HttpPost("post-body-issue-and-comments-issue")]
    [Consumes("application/json", "text/plain")]
    //[RequestBodyContentAttribute]
    //[ConfigurationResponseFilter]
    [ProducesResponseType(StatusCodes.Status202Accepted)]
    public async Task<IActionResult> PostV2Async([FromHeader] /*[UserAgent]*/ string? userAgent = null)
    {
        // description is using \n instead of \r\n and leads to weird formatting issues, it also has leading spaces
        // It's also missing the post body. Missing from open api getn.
        var streamToDiskInRealApp = Request.Body;
        return StatusCode(StatusCodes.Status202Accepted);
    }
    
    [HttpDelete("{ids}")]
    [Authorize(Policy = "User")]
    [ProducesResponseType(StatusCodes.Status202Accepted)]
    public async Task<ActionResult<WorkInProgressResult>> DeleteAsync(string ids)
    {
        // Work In ProgressResult is not generated.
        // I shouldn't need [ProducesResponseType(typeof(WorkInProgressResult), StatusCodes.Status202Accepted)]
        return WorkInProgress(ids.Split(","));
    }
    
    protected ActionResult<WorkInProgressResult> WorkInProgress(IEnumerable<string> workers)
    {
        return StatusCode(StatusCodes.Status202Accepted, new WorkInProgressResult(workers));
    }
}

public record SampleModel
{
    /// <summary>
    /// Rendered as a string with a pattern (wrong type_
    /// </summary>
    public long ShouldNotHaveRegexPattern { get; set; }
    
    [Required]
    public required string ShouldHaveMinLength { get; init; }
    
    /// <summary>
    /// "uniqueItems": true,
    /// </summary>
    public HashSet<string> ShouldHaveUniqueItemsTrue { get; set; } = new();
    
    /// <summary>
    /// Missing pattern regex "pattern": "^\\d+(\\.\\d+){1,3}$",
    /// </summary>
    public Version? Version { get; set; }
    
    /// <summary>
    /// treated as int  should have "x-enumNames and enums in "description": "\n\n0 = Trialing\n\n1 = Active\n\n2 = PastDue\n\n3 = Canceled\n\n4 = Unpaid",
    /// </summary>
    public BillingStatus BillingStatus { get; set; }
    
    public StackStatus StackStatusShouldXEnum { get; set; }
    
    public StackStatusWithJsonStringEnumMemberName StackStatusWithJsonStringEnumMemberName { get; set; }
}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum StackStatus
{
    [EnumMember(Value = "open")] Open,
    [EnumMember(Value = "fixed")] Fixed,
    [EnumMember(Value = "regressed")] Regressed,
    [EnumMember(Value = "snoozed")] Snoozed,
    [EnumMember(Value = "ignored")] Ignored,
    [EnumMember(Value = "discarded")] Discarded
}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum StackStatusWithJsonStringEnumMemberName
{
    [JsonStringEnumMemberName("open")]
    [EnumMember(Value = "open")]
    Open,
    [JsonStringEnumMemberName("fixed")]
    [EnumMember(Value = "fixed")]
    Fixed,
    [JsonStringEnumMemberName("regressed")]
    [EnumMember(Value = "regressed")]
    Regressed,
    [JsonStringEnumMemberName("snoozed")]
    [EnumMember(Value = "snoozed")]
    Snoozed,
    [JsonStringEnumMemberName("ignored")]
    [EnumMember(Value = "ignored")]
    Ignored,
    [JsonStringEnumMemberName("discarded")]
    [EnumMember(Value = "discarded")]
    Discarded
}

public enum BillingStatus
{
    Trialing = 0,
    Active = 1,
    PastDue = 2,
    Canceled = 3,
    Unpaid = 4
}

public record WorkInProgressResult
{
    public WorkInProgressResult()
    {
    }

    public WorkInProgressResult(IEnumerable<string> workers) : this()
    {
        Workers.AddRange(workers);
    }

    public List<string> Workers { get; } = new();
}
