// Create a Paper.js Path to draw a line into it:
/*var path = new Path();
// Give the stroke a color
path.strokeColor = 'black';
var start = new Point(100, 50);
// Move to start and draw a line from there
path.moveTo(start);
// Note the plus operator on Point objects.
// PaperScript does that for us, and much more!
path.lineTo(start + [100, -50]);
*/

var path = new Path.Circle(new Point(80, 50), 35);

project.activeLayer.lastChild.fillColor = 'yellow';