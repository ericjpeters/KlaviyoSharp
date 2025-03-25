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
        DataListObjectWithIncluded<Flow> result = await Fixture.AdminApi.FlowServices.GetFlows(cancellationToken: CancellationToken.None);
        result.ShouldNotBeNull();
        result.Data.ShouldNotBeNull();
        result.Data.ShouldNotBeEmpty();
    }

    [Fact]
    public async Task GetFlow()
    {
        DataObjectWithIncluded<Flow>? result = await Fixture.AdminApi.FlowServices.GetFlow(Fixture.FlowId, cancellationToken: CancellationToken.None);
        result.ShouldNotBeNull();
        result.Data.ShouldNotBeNull();
    }

    [Fact]
    public async Task UpdateFlow()
    {
        Flow update = Flow.Create();
        update.Id = Fixture.FlowId;
        update.Attributes = new() { Status = "draft" };

        DataObject<Flow>? result = await Fixture.AdminApi.FlowServices.UpdateFlowStatus(Fixture.FlowId, update, cancellationToken: CancellationToken.None);
        result.ShouldNotBeNull();
        result.Data?.Attributes?.Status.ShouldBe("draft");
    }

    [Fact]
    public async Task GetFlowActionAndMessage()
    {
        DataListObject<GenericObject>? actions = await Fixture.AdminApi.FlowServices.GetFlowRelationshipsFlowActions(Fixture.FlowId, cancellationToken: CancellationToken.None);
        DataObject<FlowAction>? result = await Fixture.AdminApi.FlowServices.GetFlowAction(actions?.Data?.First().Id, cancellationToken: CancellationToken.None);
        result.ShouldNotBeNull();
        result.Data.ShouldNotBeNull();

        DataObject<Flow>? result2 = await Fixture.AdminApi.FlowServices.GetFlowForFlowAction(result.Data.Id, cancellationToken: CancellationToken.None);
        result2.ShouldNotBeNull();
        result2.Data?.Id.ShouldBe(Fixture.FlowId);

        DataListObject<FlowMessage>? result3 = await Fixture.AdminApi.FlowServices.GetMessagesForFlowAction(result.Data.Id, cancellationToken: CancellationToken.None);
        result3.ShouldNotBeNull();

        DataObject<FlowMessage>? result4 = await Fixture.AdminApi.FlowServices.GetFlowMessage(result3.Data?.First().Id, cancellationToken: CancellationToken.None);
        result4.ShouldNotBeNull();
        result4.Data.ShouldNotBeNull();

        DataObject<FlowAction>? result5 = await Fixture.AdminApi.FlowServices.GetFlowActionForMessage(result4.Data.Id, cancellationToken: CancellationToken.None);
        result5.ShouldNotBeNull();
        result5.Data?.Id.ShouldBe(result.Data.Id);
    }

    [Fact]
    public async Task GetFlowActions()
    {
        DataListObject<FlowAction> result = await Fixture.AdminApi.FlowServices.GetFlowActionsForFlow(Fixture.FlowId, cancellationToken: CancellationToken.None);
        result.ShouldNotBeNull();
        result.Data.ShouldNotBeNull();
        result.Data.ShouldNotBeEmpty();
    }

    [Fact]
    public async Task GetFlowTags()
    {
        DataListObject<Tag>? result = await Fixture.AdminApi.FlowServices.GetFlowTags(Fixture.FlowId, cancellationToken: CancellationToken.None);
        result.ShouldNotBeNull();
    }
}
