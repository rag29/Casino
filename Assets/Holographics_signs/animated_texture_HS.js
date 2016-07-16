
//Author: Joachim Ante 
//http://www.unifycommunity.com/wiki/index.php?title=Animating_Tiled_texture


var uvAnimationTileX = 5; //Here you can place the number of columns of your sheet. 
                       
var uvAnimationTileY = 5; //Here you can place the number of rows of your sheet. 
                          //The above sheet has 1
var framesPerSecond = 18.0;

function Update () {

    // Calculate index
    var index : int = Time.time * framesPerSecond;
    // repeat when exhausting all frames
    index = index % (uvAnimationTileX * uvAnimationTileY);
    
    // Size of every tile
    var size = Vector2 (1.0 / uvAnimationTileX, 1.0 / uvAnimationTileY);
    
    // split into horizontal and vertical index
    var uIndex = index % uvAnimationTileX;
    var vIndex = index / uvAnimationTileX;

    // build offset
    // v coordinate is the bottom of the image in opengl so we need to invert.
    var offset = Vector2 (uIndex * size.x, 1.0 - size.y - vIndex * size.y);
    
    GetComponent.<Renderer>().material.SetTextureOffset ("_MainTex", offset);
    GetComponent.<Renderer>().material.SetTextureScale ("_MainTex", size);
}