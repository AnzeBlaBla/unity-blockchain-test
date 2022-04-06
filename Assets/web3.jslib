mergeInto(LibraryManager.library, {
    WalletAddress: function () {
        var returnStr
        try {
            // get address from metamask
            returnStr = web3.currentProvider.selectedAddress
        } catch (e) {
            returnStr = ""
        }
        var returnStr = web3.currentProvider.selectedAddress;
        var bufferSize = lengthBytesUTF8(returnStr) + 1;
        var buffer = _malloc(bufferSize);
        stringToUTF8(returnStr, buffer, bufferSize);
        return buffer;
    },
    CallFunc: function () {
        console.log("This is a console log from inside JS");
    },
});