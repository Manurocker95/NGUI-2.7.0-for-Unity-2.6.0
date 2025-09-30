using UnityEngine;
using System.Collections;

public struct CharacterInfo
    {
        public int index;

      
        public Rect uv;

      
        public Rect vert;

   
        public float width;

        public int size;

        public FontStyle style;

       
        public bool flipped;

        public int advance
        {
            get { return (int)width; }
            set { width = value; }
        }

        public int glyphWidth
        {
            get { return (int)vert.width; }
            set { vert.width = value; }
        }

        public int glyphHeight
        {
            get { return (int)(0f - vert.height); }
            set
            {
                float height = vert.height;
                vert.height = -value;
                vert.y += height - vert.height;
            }
        }

        public int bearing
        {
            get { return (int)vert.x; }
            set { vert.x = value; }
        }

        public int minY
        {
            get { return (int)(vert.y + vert.height); }
            set { vert.height = (float)value - vert.y; }
        }

        public int maxY
        {
            get { return (int)vert.y; }
            set
            {
                float y = vert.y;
                vert.y = value;
                vert.height += y - vert.y;
            }
        }

        public int minX
        {
            get { return (int)vert.x; }
            set
            {
                float x = vert.x;
                vert.x = value;
                vert.width += x - vert.x;
            }
        }

        public int maxX
        {
            get { return (int)(vert.x + vert.width); }
            set { vert.width = (float)value - vert.x; }
        }

        public Vector2 uvBottomLeftUnFlipped
        {
            get { return new Vector2(uv.x, uv.y); }
            set
            {
                Vector2 tr = uvTopRightUnFlipped;
                uv.x = value.x;
                uv.y = value.y;
                uv.width  = tr.x - uv.x;
                uv.height = tr.y - uv.y;
            }
        }

        public Vector2 uvBottomRightUnFlipped
        {
            get { return new Vector2(uv.x + uv.width, uv.y); }
            set
            {
                Vector2 tr = uvTopRightUnFlipped;
                uv.width = value.x - uv.x;
                uv.y = value.y;
                uv.height = tr.y - uv.y;
            }
        }

        public Vector2 uvTopRightUnFlipped
        {
            get { return new Vector2(uv.x + uv.width, uv.y + uv.height); }
            set
            {
                uv.width  = value.x - uv.x;
                uv.height = value.y - uv.y;
            }
        }

        public Vector2 uvTopLeftUnFlipped
        {
            get { return new Vector2(uv.x, uv.y + uv.height); }
            set
            {
                Vector2 tr = uvTopRightUnFlipped;
                uv.x = value.x;
                uv.height = value.y - uv.y;
                uv.width  = tr.x - uv.x;
            }
        }

        public Vector2 uvBottomLeft
        {
            get { return uvBottomLeftUnFlipped; }
            set { uvBottomLeftUnFlipped = value; }
        }

        public Vector2 uvBottomRight
        {
            get { return (!flipped) ? uvBottomRightUnFlipped : uvTopLeftUnFlipped; }
            set
            {
                if (flipped) uvTopLeftUnFlipped = value;
                else         uvBottomRightUnFlipped = value;
            }
        }

        public Vector2 uvTopRight
        {
            get { return uvTopRightUnFlipped; }
            set { uvTopRightUnFlipped = value; }
        }

        public Vector2 uvTopLeft
        {
            get { return (!flipped) ? uvTopLeftUnFlipped : uvBottomRightUnFlipped; }
            set
            {
                if (flipped) uvBottomRightUnFlipped = value;
                else         uvTopLeftUnFlipped = value;
            }
        }
    }