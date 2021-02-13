// dnlib: See LICENSE.txt for more info

namespace dnlib.DotNet {
	/// <summary>
	/// Represents a public key token
	/// </summary>
	public sealed class PublicKeyToken : PublicKeyBase {
		/// <summary>
		/// Gets the <see cref="PublicKeyToken"/>
		/// </summary>
		public override PublicKeyToken Token => this;

		/// <summary>
		/// Constructor
		/// </summary>
		public PublicKeyToken() : base((byte[])null) { }

		/// <inheritdoc/>
		public PublicKeyToken(byte[] data)
			: base(data) {
		}

		/// <inheritdoc/>
		public PublicKeyToken(string hexString)
			: base(hexString) {
		}

		/// <inheritdoc/>
		public override bool Equals(object obj) {
			if (this == obj)
				return true;
			if (obj is not PublicKeyToken other)
				return false;
			return Utils.Equals(Data, other.Data);
		}

		/// <inheritdoc/>
		public override int GetHashCode() => Utils.GetHashCode(Data);
	}
}
