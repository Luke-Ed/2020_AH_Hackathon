<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lookback.aspx.cs" Inherits="_2020_AH_Hackathon.Tracker.Lookback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>This graph represents  </p>
        </div>
        <div>
            <script src="../jsLibrary/plotly-basic.js">
               /* var x = [];
                    for (var i = 0; i < 500; i ++) {
                    	x[i] = Math.random();
                    }

                var trace = {
                     x: x,
                    type: 'histogram',
                };
                var data = [trace];
                Plotly.newPlot('myDiv', data);
                */
                var trace1 = {
                    x: [1, 2, 3, 4],
                    y: [7, 8, 3, ],
                    mode: 'markers',
                    name: 'Physical Side Effects',
                    marker: {
                    color: 'rgb(219, 14, 40)',
                    size: 12
                }
                };

            var trace2 = {
                x: [1, 2, 3, 4],
                y: [12, 9, 15, 12],
                mode: 'lines+markers',
                name: 'Stress level',
                marker: {
                    color: 'rgb(228, 175, 18)',
                    size: 8
                },
                line: {
                    color: 'rgb(228, 175, 18)',
                    width: 1
                }
                };

                var data = [trace1, trace2];

                var layout = {
                    title: 'Stress levels and days physical side effects'
                };

                Plotly.newPlot('myDiv', data, layout);


             </script>
        </div>
    </form>
</body>
</html>
