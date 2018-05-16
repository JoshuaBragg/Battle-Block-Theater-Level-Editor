h = open("images.txt", "w")

out = ""

for i in range(256):
    #print ("0x%0.2X" % i)
    out += "0x%0.2X" % i + ",res/" + "%0.2X" % i + ".png\n"

out += "0x100,res/NOTEXTURE.png"

h.write(out)

h.close()
