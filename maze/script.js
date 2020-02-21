mazeGame = (function() {
    var player = {
        x: 0,
        y: 0
    };
    var goal = {
        x: 0,
        y: 0
    }
    var maze = [
        [ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
        [ 1, 1, 1, 1, 1, 1, 1, 1, 1, 0],
        [ 1, 0, 1, 0, 0, 0, 0, 0, 1, 0],
        [ 0, 0, 0, 0, 1, 1, 1, 0, 1, 0],
        [ 0, 1, 1, 0, 0, 0, 1, 0, 1, 0],
        [ 0, 0, 1, 1, 1, 1, 1, 0, 1, 0],
        [ 1, 0, 1, 0, 0, 0, 1, 0, 1, 0],
        [ 1, 0, 1, 0, 1, 0, 1, 0, 0, 0],
        [ 1, 0, 1, 0, 1, 0, 0, 1, 1, 0],
        [-1, 0, 1, 0, 1, 1, 0, 0, 0, 0]
    ];
    var canvas = document.getElementById("Game");
    var positionInfo = canvas.getBoundingClientRect();
    var height = positionInfo.height;
    var width = positionInfo.width;
    var blockSize = width/maze.length;
    var ctx = canvas.getContext('2d');

    var startOverBtn = document.getElementById("startOverBtn");
    function draw(){
        ctx.setTransform(1, 0, 0, 1, 0, 0);
        ctx.clearRect(0, 0, width, width);
        ctx.fillStyle="white";
        //Loop through the maze array drawing the walls and the goal
        for(var y = 0; y < maze.length; y++){
            for(var x = 0; x < maze[y].length; x++){
                //Draw a wall
                if(maze[y][x] === 1){
                    ctx.fillStyle = "#000000";
                    ctx.fillRect(x*blockSize, y*blockSize, blockSize, blockSize);
                }
                //Draw the goal
                else if(maze[y][x] === -1){
                    goal.x = x;
                    goal.y = y;
                    ctx.fillStyle = "#FFFFFF";
                    ctx.fillRect(x*blockSize, y*blockSize, blockSize, blockSize);
                }
            }
            // draw a player
            ctx.fillStyle = "blue";
            ctx.fillRect(player.x*blockSize, player.y*blockSize, blockSize, blockSize);
        }
        
    }
    function canMove(x, y){
        return (y>=0) && (y<maze.length) && (x >= 0) && (x < maze[y].length) && (maze[y][x] != 1);
    }
    
    function gameOver() {
        ctx.fillStyle = "white";
        ctx.fillRect(0,0, width, width);
        // draw font in red
        ctx.fillStyle = "red";
        ctx.font = "45pt sans-serif";
        ctx.strokeText("GAME OVER!",5,130);
        
        startOverBtn.removeAttribute("hidden");


      }
      document.getElementById("startOverBtn").onclick = startOver;
      function startOver() {
          player.x=0;
          player.y=0;
          startOverBtn.setAttribute("hidden","true");
          draw();
      }
    document.addEventListener("keydown", event => {
        if((event.which == 38) && canMove(player.x, player.y-1))//Up arrow
            player.y--;
        else if((event.which == 40) && canMove(player.x, player.y+1)) // down arrow
            player.y++;
        else if((event.which == 37) && canMove(player.x-1, player.y))
            player.x--;
        else if((event.which == 39) && canMove(player.x+1, player.y))
            player.x++;
        
        draw();
        if(player.x == goal.x && player.y == goal.y) {gameOver();}
      });
      
    draw();
})();