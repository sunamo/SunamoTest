namespace SunamoTest;

/// <summary>
/// Represents the xml tests base type.
/// </summary>
public class XmlTestsBase
{
    /// <summary>
    /// Gets or sets the xlf path.
    /// </summary>
    protected string xlfPath { get; set; } = Path.Combine(Path.GetTempPath(), "SunamoTest", "XH", "xlf.xml");

    /// <summary>
    /// Gets or sets the single para xml.
    /// </summary>
    protected string singleParaXml { get; set; } = @"<Cell>
    <CellContent>
        <Para>
            <ParaLine>
                <String>ABCabcABC abcABC abc ABCABCABC.</String>
            </ParaLine>
        </Para>
    </CellContent>
</Cell>";

    /// <summary>
    /// Gets or sets the double para xml.
    /// </summary>
    protected string doubleParaXml { get; set; } = @"<Cell>
    <CellContent>
        <Para>
            <ParaLine>
                <String>ABCabcABC abcABC abc ABCABCABC.</String>
            </ParaLine>
        </Para>
<Para>
            <ParaLine>
                <String>ABCabcABC abcABC abc ABCABCABC.</String>
            </ParaLine>
        </Para>
    </CellContent>
</Cell>";

    /// <summary>
    /// Gets or sets the double para with attribute xml.
    /// </summary>
    protected string doubleParaWithAttributeXml { get; set; } = @"<Cell Sdk='a'>
    <CellContent>
        <Para>
            <ParaLine>
                <String>ABCabcABC abcABC abc ABCABCABC.</String>
            </ParaLine>
        </Para>
<Para>
            <ParaLine>
                <String>ABCabcABC abcABC abc ABCABCABC.</String>
            </ParaLine>
        </Para>
    </CellContent>
</Cell>";

    /// <summary>
    /// Gets or sets the project with version xml.
    /// </summary>
    protected string projectWithVersionXml { get; set; } = @"<Project Sdk='a'>
    <PropertyGroup>
        <Version>23.11.6.1</Version>
    </PropertyGroup>
    <PropertyGroup>
        <Version>Second</Version>
    </PropertyGroup>
</Project>";

    /// <summary>
    /// Gets or sets the project with condition xml.
    /// </summary>
    protected string projectWithConditionXml { get; set; } = @"<Project Sdk='a'>
    " + "<PropertyGroup Condition=\"'$(Configuration)|$(Platform)'=='Debug|AnyCPU'\"" + @">
        <Version>23.11.6.1</Version>
    </PropertyGroup>
    <PropertyGroup>
        <Version>Second</Version>
    </PropertyGroup>
</Project>";

    /// <summary>
    /// Gets or sets the project with condition and custom elements xml.
    /// </summary>
    protected string projectWithConditionAndCustomElementsXml { get; set; } = @"<Project Sdk='a'>
    " + "<PropertyGroup Condition=\"'$(Configuration)|$(Platform)'=='Debug|AnyCPU'\"" + @">
        <Ne>23.11.6.1</Ne>
    </PropertyGroup>
    <PropertyGroup>
        <So>Second</So>
    </PropertyGroup>
</Project>";
}
