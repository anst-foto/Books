using System.Windows;
using System.Windows.Controls;

namespace Books.MVVM.Components.InputComponent;

public partial class InputComponent : UserControl
{
    public static readonly DependencyProperty LabelProperty =
        DependencyProperty.Register(nameof(Label), typeof(string), typeof(InputComponent));
    public string? Label
    {
        get => GetValue(LabelProperty).ToString();
        set => SetValue(LabelProperty, value);
    }
    
    public static readonly DependencyProperty InputProperty = DependencyProperty.Register(
            name: nameof(Input), 
            propertyType: typeof(string), 
            ownerType: typeof(InputComponent), 
            typeMetadata: new FrameworkPropertyMetadata(
                defaultValue: string.Empty,
                flags: FrameworkPropertyMetadataOptions.AffectsMeasure |
                       FrameworkPropertyMetadataOptions.AffectsRender |
                       FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
    public string? Input
    {
        get => GetValue(InputProperty).ToString();
        set => SetValue(InputProperty, value);
    }
    
    public InputComponent()
    {
        InitializeComponent();
    }
}