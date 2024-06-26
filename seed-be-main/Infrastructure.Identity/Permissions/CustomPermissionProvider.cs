using System.Collections.Generic;

namespace Infrastructure.Identity.Permissions
{
    public static class CustomPermissionProvider
    {
        public const string ManageUser = nameof(ManageUser);
        public const string ManageRole = nameof(ManageRole);
        public const string ManagePermission = nameof(ManagePermission);
        public const string ReadUser = nameof(ReadUser);
        public const string CreateUser = nameof(CreateUser);
        public const string UpdateUser = nameof(UpdateUser);
        public const string DeleteUser = nameof(DeleteUser);
        public const string ReadRole = nameof(ReadRole);
        public const string CreateRole = nameof(CreateRole);
        public const string UpdateRole = nameof(UpdateRole);
        public const string DeleteRole = nameof(DeleteRole);

        public static IReadOnlyList<string> GetAll() => new List<string>
        {
            ManageUser,
            ManageRole,
            ReadUser,
            CreateUser,
            UpdateUser,
            DeleteUser,
            ReadRole,
            CreateRole,
            UpdateRole,
            DeleteRole
        };
    }
    public class PermissionProvider : IPermissionProvider
    {
        public const string ThuTucNoiBo_XemTongQuan = nameof(ThuTucNoiBo_XemTongQuan);
        public const string HoSoNoiBo_XemTatCa = nameof(HoSoNoiBo_XemTatCa);
        public const string HoSoNoiBo_Xoa = nameof(HoSoNoiBo_Xoa);
        public const string HoSoNoiBo_Sua = nameof(HoSoNoiBo_Sua);
        public const string HoSoNoiBo_XemChiTiet = nameof(HoSoNoiBo_XemChiTiet);
        public const string HoSoNoiBo_Them = nameof(HoSoNoiBo_Them);
        public const string HoSoNoiBo_CapNhapTienDo = nameof(HoSoNoiBo_CapNhapTienDo);
        public const string HoSoNoiBo_CapNhapKetQua = nameof(HoSoNoiBo_CapNhapKetQua);
        public const string HoSoNoiBo_LuKho = nameof(HoSoNoiBo_LuKho);
        public const string QuanLyLuuKho_HuyLuuKho = nameof(QuanLyLuuKho_HuyLuuKho);
        public const string QuanLyLuuKho_CapNhatKetQua = nameof(QuanLyLuuKho_CapNhatKetQua);
        public const string QuanLyLuuKho_XemTatCa = nameof(QuanLyLuuKho_XemTatCa);
        public const string QuanLyLuuKho_XemChiTiet = nameof(QuanLyLuuKho_XemChiTiet);
        public const string TaiLieuThongBao_XemTatCa = nameof(TaiLieuThongBao_XemTatCa);
        public const string TaiLieuThongBao_Them = nameof(TaiLieuThongBao_Them);
        public const string TaiLieuThongBao_Sua = nameof(TaiLieuThongBao_Sua);
        public const string TaiLieuThongBao_Xoa = nameof(TaiLieuThongBao_Xoa);
        public const string TaiLieuThongBao_XemChiTiet = nameof(TaiLieuThongBao_XemChiTiet);
        public const string TaiLieuThongBao_DangTai = nameof(TaiLieuThongBao_DangTai);
        public const string TaiLieuThongBao_GuiSms = nameof(TaiLieuThongBao_GuiSms);
        public const string TaiLieuThongBao_TheoDoi = nameof(TaiLieuThongBao_TheoDoi);
        public const string KeHoachTrungHan_Them = nameof(KeHoachTrungHan_Them);
        public const string KeHoachTrungHan_Sua = nameof(KeHoachTrungHan_Sua);
        public const string KeHoachTrungHan_Xoa = nameof(KeHoachTrungHan_Xoa);
        public const string KeHoachTrungHan_DieuChinh = nameof(KeHoachTrungHan_DieuChinh);
        public const string KeHoachTrungHan_XemTatCa = nameof(KeHoachTrungHan_XemTatCa);
        public const string KeHoachTrungHan_XemChiTiet = nameof(KeHoachTrungHan_XemChiTiet);
        public const string DuAn_Them = nameof(DuAn_Them);
        public const string DuAn_Sua = nameof(DuAn_Sua);
        public const string DuAn_Xoa = nameof(DuAn_Xoa);
        public const string DuAn_XemTatCa = nameof(DuAn_XemTatCa);
        public const string DuAn_DieuChinh = nameof(DuAn_DieuChinh);
        public const string DuAn_XemChiTiet = nameof(DuAn_XemChiTiet);
        public const string DuAn_Import = nameof(DuAn_Import);
        public const string DuAn_Export = nameof(DuAn_Export);
        public const string NhiemVu_Them = nameof(NhiemVu_Them);
        public const string NhiemVu_Sua = nameof(NhiemVu_Sua);
        public const string NhiemVu_Xoa = nameof(NhiemVu_Xoa);
        public const string NhiemVu_XemTatCa = nameof(NhiemVu_XemTatCa);
        public const string NhiemVu_XemChiTiet = nameof(NhiemVu_XemChiTiet);
        public const string NhiemVu_DieuChinh = nameof(NhiemVu_DieuChinh);
        public const string LuyKe_Them = nameof(LuyKe_Them);
        public const string LuyKe_Sua = nameof(LuyKe_Sua);
        public const string LuyKe_Xoa = nameof(LuyKe_Xoa);
        public const string LuyKe_XemTatCa = nameof(LuyKe_XemTatCa);
        public const string LuyKe_XemChiTiet = nameof(LuyKe_XemChiTiet);
        public const string NganSachTinh_Them = nameof(NganSachTinh_Them);
        public const string NganSachTinh_Sua = nameof(NganSachTinh_Sua);
        public const string NganSachTinh_Xoa = nameof(NganSachTinh_Xoa);
        public const string NganSachTinh_XemTatCa = nameof(NganSachTinh_XemTatCa);
        public const string NganSachTinh_XemChiTiet = nameof(NganSachTinh_XemChiTiet);
        public const string NganSachTinh_XoaGiaiNgan = nameof(NganSachTinh_XoaGiaiNgan);
        public const string NganSachTinh_SuaGiaiNgan = nameof(NganSachTinh_SuaGiaiNgan);
        public const string NganSachTinh_GiaiNgan = nameof(NganSachTinh_GiaiNgan);
        public const string VonHuyen_Them = nameof(VonHuyen_Them);
        public const string VonHuyen_Sua = nameof(VonHuyen_Sua);
        public const string VonHuyen_SuaTongHop = nameof(VonHuyen_SuaTongHop);
        public const string VonHuyen_Xoa = nameof(VonHuyen_Xoa);
        public const string VonHuyen_XoaTongHop = nameof(VonHuyen_XoaTongHop);
        public const string VonHuyen_XemTatCa = nameof(VonHuyen_XemTatCa);
        public const string VonHuyen_XemChiTiet = nameof(VonHuyen_XemChiTiet);
        public const string VonHuyen_DieuChinh = nameof(VonHuyen_DieuChinh);
        public const string VonHuyen_GiaiNgan = nameof(VonHuyen_GiaiNgan);
        public const string ThuTienSuDungDat_Them = nameof(ThuTienSuDungDat_Them);
        public const string ThuTienSuDungDat_Sua = nameof(ThuTienSuDungDat_Sua);
        public const string ThuTienSuDungDat_Xoa = nameof(ThuTienSuDungDat_Xoa);
        public const string ThuTienSuDungDat_XemTatCa = nameof(ThuTienSuDungDat_XemTatCa);
        public const string ThuTienSuDungDat_XemChiTiet = nameof(ThuTienSuDungDat_XemChiTiet);
        public const string TienDoThucHienDuAn_Them = nameof(TienDoThucHienDuAn_Them);
        public const string TienDoThucHienDuAn_Sua = nameof(TienDoThucHienDuAn_Sua);
        public const string TienDoThucHienDuAn_Xoa = nameof(TienDoThucHienDuAn_Xoa);
        public const string TienDoThucHienDuAn_XemTatCa = nameof(TienDoThucHienDuAn_XemTatCa);
        public const string TienDoThucHienDuAn_XemChiTiet = nameof(TienDoThucHienDuAn_XemChiTiet);
        public const string QuanTriDanhMuc_Them = nameof(QuanTriDanhMuc_Them);
        public const string QuanTriDanhMuc_Sua = nameof(QuanTriDanhMuc_Sua);
        public const string QuanTriDanhMuc_Xoa = nameof(QuanTriDanhMuc_Xoa);
        public const string QuanTriDanhMuc_XemTatCa = nameof(QuanTriDanhMuc_XemTatCa);
        public const string QuanTriDanhMuc_XemChiTiet = nameof(QuanTriDanhMuc_XemChiTiet);
        public const string KeHoachHangNam_Them = nameof(KeHoachHangNam_Them);
        public const string KeHoachHangNam_Sua = nameof(KeHoachHangNam_Sua);
        public const string KeHoachHangNam_Xoa = nameof(KeHoachHangNam_Xoa);
        public const string KeHoachHangNam_XemTatCa = nameof(KeHoachHangNam_XemTatCa);
        public const string KeHoachHangNam_XemChiTiet = nameof(KeHoachHangNam_XemChiTiet);
        public const string KeHoachHangNam_Import = nameof(KeHoachHangNam_Import);
        public const string KeHoachHangNam_Export = nameof(KeHoachHangNam_Export);
        public const string KeHoachHangNam_GiaiNgan = nameof(KeHoachHangNam_GiaiNgan);
        public const string KeHoachHangNam_DieuChinh = nameof(KeHoachHangNam_DieuChinh);
        public const string GiaiNganKBNN_XemTatCa = nameof(GiaiNganKBNN_XemTatCa);
        public const string GiaiNganKBNN_XemChiTiet = nameof(GiaiNganKBNN_XemChiTiet);
        public const string GiaiNganKBNN_Them = nameof(GiaiNganKBNN_Them);
        public const string GiaiNganKBNN_Sua = nameof(GiaiNganKBNN_Sua);
        public const string GiaiNganKBNN_Xoa = nameof(GiaiNganKBNN_Xoa);
        public const string TrangChu_XemTatCa = nameof(TrangChu_XemTatCa);
        public const string QuanTriCauHinh_XemTatCa = nameof(QuanTriCauHinh_XemTatCa);

        public IReadOnlyList<string> GetAll()
        {
            return new List<string> {
           ThuTucNoiBo_XemTongQuan,
HoSoNoiBo_XemTatCa,
HoSoNoiBo_Xoa,
HoSoNoiBo_Sua,
HoSoNoiBo_XemChiTiet,
HoSoNoiBo_Them,
HoSoNoiBo_CapNhapTienDo,
HoSoNoiBo_CapNhapKetQua,
HoSoNoiBo_LuKho,
QuanLyLuuKho_HuyLuuKho,
QuanLyLuuKho_CapNhatKetQua,
QuanLyLuuKho_XemTatCa,
QuanLyLuuKho_XemChiTiet,
TaiLieuThongBao_XemTatCa,
TaiLieuThongBao_Them,
TaiLieuThongBao_Sua,
TaiLieuThongBao_Xoa,
TaiLieuThongBao_XemChiTiet,
TaiLieuThongBao_DangTai,
TaiLieuThongBao_GuiSms,
TaiLieuThongBao_TheoDoi,
KeHoachTrungHan_Them,
KeHoachTrungHan_Sua,
KeHoachTrungHan_Xoa,
KeHoachTrungHan_DieuChinh,
KeHoachTrungHan_XemTatCa,
KeHoachTrungHan_XemChiTiet,
DuAn_Them,
DuAn_Sua,
DuAn_Xoa,
DuAn_XemTatCa,
DuAn_DieuChinh,
DuAn_XemChiTiet,
DuAn_Import,
DuAn_Export,
NhiemVu_Them,
NhiemVu_Sua,
NhiemVu_Xoa,
NhiemVu_XemTatCa,
NhiemVu_XemChiTiet,
NhiemVu_DieuChinh,
LuyKe_Them,
LuyKe_Sua,
LuyKe_Xoa,
LuyKe_XemTatCa,
LuyKe_XemChiTiet,
NganSachTinh_Them,
NganSachTinh_Sua,
NganSachTinh_Xoa,
NganSachTinh_XemTatCa,
NganSachTinh_XemChiTiet,
NganSachTinh_XoaGiaiNgan,
NganSachTinh_SuaGiaiNgan,
NganSachTinh_GiaiNgan,
VonHuyen_Them,
VonHuyen_Sua,
VonHuyen_Xoa,
VonHuyen_XoaTongHop,
VonHuyen_SuaTongHop,
VonHuyen_XemTatCa,
VonHuyen_XemChiTiet,
VonHuyen_DieuChinh,
VonHuyen_GiaiNgan,
ThuTienSuDungDat_Them,
ThuTienSuDungDat_Sua,
ThuTienSuDungDat_Xoa,
ThuTienSuDungDat_XemTatCa,
ThuTienSuDungDat_XemChiTiet,
TienDoThucHienDuAn_Them,
TienDoThucHienDuAn_Sua,
TienDoThucHienDuAn_Xoa,
TienDoThucHienDuAn_XemTatCa,
TienDoThucHienDuAn_XemChiTiet,
QuanTriDanhMuc_Them,
QuanTriDanhMuc_Sua,
QuanTriDanhMuc_Xoa,
QuanTriDanhMuc_XemTatCa,
QuanTriDanhMuc_XemChiTiet,
KeHoachHangNam_Them,
KeHoachHangNam_Sua,
KeHoachHangNam_Xoa,
KeHoachHangNam_XemTatCa,
KeHoachHangNam_XemChiTiet,
KeHoachHangNam_Import,
KeHoachHangNam_Export,
KeHoachHangNam_GiaiNgan,
KeHoachHangNam_DieuChinh,
GiaiNganKBNN_XemTatCa,
GiaiNganKBNN_XemChiTiet,
GiaiNganKBNN_Them,
GiaiNganKBNN_Sua,
GiaiNganKBNN_Xoa,
TrangChu_XemTatCa,
QuanTriCauHinh_XemTatCa,
            };
        }
    }
}
