import Link from 'next/link'

export default function Header() {
	return (
		<header className="header">
			<img src="/logo.png" alt="logo" />
			<ul>
				<li>
					<Link href="/RotaUm">Destinos</Link>
				</li>
				<li>
					<Link href="/RotaDois">Contato</Link>
				</li>
				<li>
					<Link href="/RotaTres">Login</Link>
				</li>
			</ul>
		</header>
	)
}