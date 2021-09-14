export default function isDigit(text) {
    let isnum = /^\d+$/.test(text);

    return isnum;
}