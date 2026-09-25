namespace SunamoTest;

/// <summary>
/// Base class providing XML test data strings for XML-related unit tests.
/// </summary>
public class XmlTestsBase
{
    /// <summary>
    /// Path to the XLF test file.
    /// </summary>
    protected string xlfPath { get; set; } = Path.Combine(Path.GetTempPath(), "SunamoTest", "XH", "xlf.xml");

    /// <summary>
    /// XML test data with a single Cell/Para/ParaLine/String structure.
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
    /// XML test data with two Para elements inside a Cell.
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
    /// XML test data with two Para elements and an Sdk attribute on the root Cell element.
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
    /// XML test data representing a Project with two PropertyGroup/Version elements.
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
    /// XML test data representing a Project with a conditional PropertyGroup and Version elements.
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
    /// XML test data representing a Project with a conditional PropertyGroup containing custom elements.
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
