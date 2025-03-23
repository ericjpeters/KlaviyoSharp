using Shouldly;

namespace KlaviyoSharp.Tests;

[Trait("Category", "TemplateServices")]
public class TemplateServices_Tests : IClassFixture<TemplateServices_Tests_Fixture>
{
    private TemplateServices_Tests_Fixture Fixture { get; }

    public TemplateServices_Tests(TemplateServices_Tests_Fixture fixture)
    {
        Fixture = fixture;
    }

    [Fact]
    public async Task TemplateTests()
    {
        var newTemplate = Models.Template.Create();
        newTemplate.Attributes = new()
        {
            Name = $"Test Template {DateTime.Now}",
            EditorType = "CODE",
            Html = "<html><head></head><body><h1>Test {{ first_name|default:\"\" }}</h1></body></html>"
        };


        //Create
        var createdTemplate = await Fixture.AdminApi.TemplateServices.CreateTemplate(newTemplate);
        createdTemplate.ShouldNotBeNull();
        createdTemplate.Data.ShouldNotBeNull();

        //Get
        var templates = await Fixture.AdminApi.TemplateServices.GetTemplates();
        templates.ShouldNotBeNull();
        templates.Data.ShouldNotBeNull();
        templates.Data.ShouldNotBeEmpty();

        var template = await Fixture.AdminApi.TemplateServices.GetTemplate(createdTemplate.Data.Id);
        template.ShouldNotBeNull();
        template.Data.ShouldNotBeNull();

        //Update
        var updateTemplate = Models.Template.Create();
        updateTemplate.Id = template.Data.Id;
        updateTemplate.Attributes = new()
        {
            Name = $"{template.Data.Attributes?.Name} Updated",
            Html = template.Data.Attributes?.Html?.Replace("h1", "h2")
        };
        var updatedTemplate = await Fixture.AdminApi.TemplateServices.UpdateTemplate(updateTemplate.Id, updateTemplate);
        updatedTemplate?.Data?.Attributes?.Html.ShouldBe(template.Data.Attributes?.Html?.Replace("h1", "h2"));

        //Render
        var renderObject = Models.Template.Create();
        renderObject.Attributes = new()
        {
            Id = template.Data.Id,
            Context = new() { { "first_name", "Test" } }
        };
        var render = await Fixture.AdminApi.TemplateServices.CreateTemplateRender(renderObject);
        render?.Data?.Attributes?.Html.ShouldBe(updatedTemplate?.Data?.Attributes?.Html?.Replace("{{ first_name|default:\"\" }}", renderObject.Attributes.Context["first_name"]));

        //Clone
        var cloneObject = Models.Template.Create();
        cloneObject.Attributes = new()
        {
            Id = template.Data.Id,
            Name = $"{template.Data.Attributes?.Name} Cloned"
        };
        var clone = await Fixture.AdminApi.TemplateServices.CreateTemplateClone(cloneObject);

        //Delete
        await Fixture.AdminApi.TemplateServices.DeleteTemplate(clone?.Data?.Id);
        await Fixture.AdminApi.TemplateServices.DeleteTemplate(template.Data.Id);
    }
}

public class TemplateServices_Tests_Fixture : IAsyncLifetime
{
    public KlaviyoAdminApi AdminApi { get; } = new(Config.ApiKey);
    public Task DisposeAsync()
    {
        return Task.CompletedTask;
    }
    public Task InitializeAsync()
    {
        return Task.CompletedTask;
    }
}
