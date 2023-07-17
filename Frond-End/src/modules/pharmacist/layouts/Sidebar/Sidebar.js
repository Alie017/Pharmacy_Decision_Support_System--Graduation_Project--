import React from 'react'

import { Link } from 'react-router-dom'
import { useSelector } from 'react-redux'

import { FaHome } from 'react-icons/fa'
import { FaSearch } from 'react-icons/fa'
import { FaGlobeEurope } from 'react-icons/fa'
import { FaRegListAlt } from 'react-icons/fa'
import { FaLightbulb } from 'react-icons/fa'
import { FaUser } from 'react-icons/fa'
import styles from './Sidebar.module.css'

export default function Sidebar() {
	const { theme } = useSelector(state => state.theme)
  return (
		<nav className={`${styles.sidebar} ${theme === 'dark' && styles.dark}`}>
			<ul>
				<li>
					<Link to='/pharmacist'>
						<FaHome />
					</Link>
				</li>
				<li>
					<Link to='/pharmacist/search-drug'>
						<FaSearch />
					</Link>
				</li>
				<li>
					<Link to='/pharmacist/documentations'>
						<FaRegListAlt />
					</Link>
				</li>
				<li>
					<Link to='/pharmacist/give-advice'>
						<FaLightbulb />
					</Link>
				</li>
				<li>
					<Link to='/medulla'>
						<FaGlobeEurope />
					</Link>
				</li>
			</ul>
		</nav>
	)
}
