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
        Models.Template newTemplate = Models.Template.Create();
        newTemplate.Attributes = new()
        {
            Name = $"Test Template {DateTime.Now}",
            EditorType = "CODE",
            Html = "<html><head></head><body><h1>Test {{ first_name|default:\"\" }}</h1></body></html>"
        };


        //Create
        Models.DataObject<Models.Template>? createdTemplate = await Fixture.AdminApi.TemplateServices.CreateTemplate(newTemplate, cancellationToken: CancellationToken.None);
        createdTemplate.ShouldNotBeNull();
        createdTemplate.Data.ShouldNotBeNull();

        //Get
        Models.DataListObject<Models.Template> templates = await Fixture.AdminApi.TemplateServices.GetTemplates(cancellationToken: CancellationToken.None);
        templates.ShouldNotBeNull();
        templates.Data.ShouldNotBeNull();
        templates.Data.ShouldNotBeEmpty();

        Models.DataObject<Models.Template>? template = await Fixture.AdminApi.TemplateServices.GetTemplate(createdTemplate.Data.Id, cancellationToken: CancellationToken.None);
        template.ShouldNotBeNull();
        template.Data.ShouldNotBeNull();

        //Update
        Models.Template updateTemplate = Models.Template.Create();
        updateTemplate.Id = template.Data.Id;
        updateTemplate.Attributes = new()
        {
            Name = $"{template.Data.Attributes?.Name} Updated",
            Html = template.Data.Attributes?.Html?.Replace("h1", "h2")
        };
        Models.DataObject<Models.Template>? updatedTemplate = await Fixture.AdminApi.TemplateServices.UpdateTemplate(updateTemplate.Id, updateTemplate, cancellationToken: CancellationToken.None);
        updatedTemplate?.Data?.Attributes?.Html.ShouldBe(template.Data.Attributes?.Html?.Replace("h1", "h2"));

        //Render
        Models.Template renderObject = Models.Template.Create();
        renderObject.Attributes = new()
        {
            Id = template.Data.Id,
            Context = new() { { "first_name", "Test" } }
        };
        Models.DataObject<Models.Template>? render = await Fixture.AdminApi.TemplateServices.CreateTemplateRender(renderObject, cancellationToken: CancellationToken.None);
        render?.Data?.Attributes?.Html.ShouldBe(updatedTemplate?.Data?.Attributes?.Html?.Replace("{{ first_name|default:\"\" }}", renderObject.Attributes.Context["first_name"]));

        //Clone
        Models.Template cloneObject = Models.Template.Create();
        cloneObject.Attributes = new()
        {
            Id = template.Data.Id,
            Name = $"{template.Data.Attributes?.Name} Cloned"
        };
        Models.DataObject<Models.Template>? clone = await Fixture.AdminApi.TemplateServices.CreateTemplateClone(cloneObject, cancellationToken: CancellationToken.None);

        //Delete
        await Fixture.AdminApi.TemplateServices.DeleteTemplate(clone?.Data?.Id, cancellationToken: CancellationToken.None);
        await Fixture.AdminApi.TemplateServices.DeleteTemplate(template.Data.Id, cancellationToken: CancellationToken.None);
    }
}
