using KlaviyoSharp.Models;
using Shouldly;

namespace KlaviyoSharp.Tests;

[Trait("Category", "FlowServices")]
public class FlowServices_Tests : IClassFixture<FlowServices_Tests_Fixture>
{
    private FlowServices_Tests_Fixture Fixture { get; }

    public FlowServices_Tests(FlowServices_Tests_Fixture fixture)
    {
        Fixture = fixture;
    }

    [Fact]
    public async Task GetFlows()
    {
        var result = await Fixture.AdminApi.FlowServices.GetFlows();
        result.ShouldNotBeNull();
        result.Data.ShouldNotBeNull();
        result.Data.ShouldNotBeEmpty();
    }

    [Fact]
    public async Task GetFlow()
    {
        var result = await Fixture.AdminApi.FlowServices.GetFlow(Fixture.FlowId);
        result.ShouldNotBeNull();
        result.Data.ShouldNotBeNull();
    }

    [Fact]
    public async Task UpdateFlow()
    {
        var update = Flow.Create();
        update.Id = Fixture.FlowId;
        update.Attributes = new() { Status = "draft" };
        
        var result = await Fixture.AdminApi.FlowServices.UpdateFlowStatus(Fixture.FlowId, update);
        result.ShouldNotBeNull();
        result.Data?.Attributes?.Status.ShouldBe("draft");
    }

    [Fact]
    public async Task GetFlowActionAndMessage()
    {
        var actions = await Fixture.AdminApi.FlowServices.GetFlowRelationshipsFlowActions(Fixture.FlowId);
        var result = await Fixture.AdminApi.FlowServices.GetFlowAction(actions?.Data?.First().Id);
        result.ShouldNotBeNull();
        result.Data.ShouldNotBeNull();

        var result2 = await Fixture.AdminApi.FlowServices.GetFlowForFlowAction(result.Data.Id);
        result2.ShouldNotBeNull();
        result2.Data?.Id.ShouldBe(Fixture.FlowId);

        var result3 = await Fixture.AdminApi.FlowServices.GetMessagesForFlowAction(result.Data.Id);
        result3.ShouldNotBeNull();

        var result4 = await Fixture.AdminApi.FlowServices.GetFlowMessage(result3.Data?.First().Id);
        result4.ShouldNotBeNull();
        result4.Data.ShouldNotBeNull();

        var result5 = await Fixture.AdminApi.FlowServices.GetFlowActionForMessage(result4.Data.Id);
        result5.ShouldNotBeNull();
        result5.Data?.Id.ShouldBe(result.Data.Id);
    }

    [Fact]
    public async Task GetFlowActions()
    {
        var result = await Fixture.AdminApi.FlowServices.GetFlowActionsForFlow(Fixture.FlowId);
        result.ShouldNotBeNull();
        result.Data.ShouldNotBeNull();
        result.Data.ShouldNotBeEmpty();
    }

    [Fact]
    public async Task GetFlowTags()
    {
        var result = await Fixture.AdminApi.FlowServices.GetFlowTags(Fixture.FlowId);
        result.ShouldNotBeNull();
    }
}

public class FlowServices_Tests_Fixture : IAsyncLifetime
{
    public KlaviyoAdminApi AdminApi { get; } = new(Config.ApiKey);
    public string? FlowId { get; set; }

    public Task DisposeAsync()
    {
        return Task.CompletedTask;
    }

    public Task InitializeAsync()
    {
        FlowId = AdminApi.FlowServices.GetFlows().Result.Data?.First().Id;
        return Task.CompletedTask;
    }
}