namespace SunamoTest;

public class XmlTestsBase
{
    protected string xlfPath { get; set; } = Path.Combine(Path.GetTempPath(), "SunamoTest", "XH", "xlf.xml");

    protected string singleParaXml { get; set; } = @"<Cell>
    <CellContent>
        <Para>
            <ParaLine>
                <String>ABCabcABC abcABC abc ABCABCABC.</String>
            </ParaLine>
        </Para>
    </CellContent>
</Cell>";

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

    protected string projectWithVersionXml { get; set; } = @"<Project Sdk='a'>
    <PropertyGroup>
        <Version>23.11.6.1</Version>
    </PropertyGroup>
    <PropertyGroup>
        <Version>Second</Version>
    </PropertyGroup>
</Project>";

    protected string projectWithConditionXml { get; set; } = @"<Project Sdk='a'>
    " + "<PropertyGroup Condition=\"'$(Configuration)|$(Platform)'=='Debug|AnyCPU'\"" + @">
        <Version>23.11.6.1</Version>
    </PropertyGroup>
    <PropertyGroup>
        <Version>Second</Version>
    </PropertyGroup>
</Project>";

    protected string projectWithConditionAndCustomElementsXml { get; set; } = @"<Project Sdk='a'>
    " + "<PropertyGroup Condition=\"'$(Configuration)|$(Platform)'=='Debug|AnyCPU'\"" + @">
        <Ne>23.11.6.1</Ne>
    </PropertyGroup>
    <PropertyGroup>
        <So>Second</So>
    </PropertyGroup>
</Project>";
}
