<Window x:Class="MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="WPF Canvas Tutorial ByDR" Height="344.485" Width="398.971">
    <Canvas>
        <Ellipse Panel.ZIndex="2" Fill="Gold" Canvas.Left="25" Canvas.Top="25" Width="200" Height="200" />
        <Rectangle Panel.ZIndex="3" Fill="Red" Canvas.Left="25" Canvas.Top="25" Width="50" Height="50" />
        <Rectangle Panel.ZIndex="2" Fill="Black" Canvas.Left="50" Canvas.Top="50" Width="50" Height="50" />
        <Rectangle Panel.ZIndex="4" Fill="Green" Canvas.Left="75" Canvas.Top="75" Width="50" Height="50" />
    </Canvas>
</Window>