namespace Tranquil.Schema;

public record CUIFontFilePB(string font_file_name, byte[] opentype_font_data) : DotaPacket;
public record CUIFontFilePackagePB(uint package_version, List<CUIFontFilePackagePB.CUIEncryptedFontFilePB> encrypted_font_files) : DotaPacket
{
    public record CUIEncryptedFontFilePB(byte[] encrypted_contents);
}
